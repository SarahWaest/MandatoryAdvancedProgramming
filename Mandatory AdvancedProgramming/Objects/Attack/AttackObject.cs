using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Mandatory_AdvancedProgramming.Objects.Attack
{
    public class AttackObject 
    {
        private string _name;
        private Position _position;
        private int _minDamage;
        private int _maxDamage;
        private bool _enchanced;

        public int MinDamage
        {
            get { return _minDamage;}
            private set { _minDamage = value; }
        }

        public int MaxDamage
        {
            get { return _maxDamage; }
            private set { _maxDamage = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public AttackObject(string name, Position position, int minDamage, int maxDamage, bool enchanced)
        {
            _name = name;
            _position = position;
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            _enchanced = enchanced;
        }

        public AttackObject(string name, int minDamage, int maxDamage, bool enchanced)
        {
            _name = name;
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            _enchanced = enchanced;
        }

        /// <summary>
        /// Returns the amount of points a Character deals in damage.
        /// This damage could then be received by another character.
        /// Note that there is a chance that the damage is modified.
        /// </summary>
        public int DealDamage()
        {
            int damage = RandomNumberGenerator.RandomNumber(_minDamage, _maxDamage);
            string message = $"{Name} dealt {damage} in damage";
            BattleLog.Save(message);
            return damage;
        }
    }
}