using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using Mandatory_AdvancedProgramming.Objects.Attack;
using Mandatory_AdvancedProgramming.Objects.Defence;

namespace Mandatory_AdvancedProgramming.Objects
{
    public class Creature
    {
        #region Instance fields
        private string _name;
        protected int _hitPoints;
        protected int _maxHitPoints;
        private Position _creaturePosition;
        private DefenceObject _defenceObject;
        private AttackObject _attackObject;
        #endregion

        #region Constructor
        public Creature(string name, int hitPoints, int maxHitPoints, Position creaturePosition, DefenceObject defenceObject, AttackObject attackObject)
        {
            _name = name;
            _hitPoints = hitPoints;
            _maxHitPoints = maxHitPoints;
            _creaturePosition = creaturePosition;
            _defenceObject = defenceObject;
            _attackObject = attackObject;
            Reset();
        }
        public Creature()
        {

        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// Checks if the Character is dead, defined as having 0 or less hit points...
        /// </summary>
        public bool Dead
        {
            get { return (_hitPoints <= 0); }
        }

        public bool Alive
        {
            get { return (_hitPoints >= 0); }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Reset the Character's state to the original state
        /// </summary>
        public void Reset()
        {
            _hitPoints = _maxHitPoints;
        }

        public int DealDamage()
        {
            return _attackObject.DealDamage();
        }

        public void ReceiveDamage(int damage)
        {
            int armor = 0;
            foreach (DefenceObject defence in BackPack)
            {
                if (defence.Enchanced)
                {
                    armor += defence.MinDefence + 1;
                    armor += defence.MaxDefence + 1;
                }
                else
                {
                    armor += defence.MinDefence;
                    armor += defence.MaxDefence;
                }
            }

            _hitPoints += armor;
            _hitPoints -= damage;

            string message = $"{Name} receives {damage} damage , and is down to {_hitPoints} HP";


            BattleLog.Save(message);
            if (Dead)
            {
                BattleLog.Save(Name + " died!");
                LogDead();
            }

            if (Alive)
            {
                LogSurvivor();
            }
        }

        /// <summary>
        /// Log data about the character to the battle log.
        /// </summary>
        public void LogSurvivor()
        {
            if (!Dead)
            {
                BattleLog.Save(Name + " survived with " + _hitPoints + " hit points left");
            }
        }

        public void LogDead()
        {
            if (Dead)
            {
                BattleLog.Save(Name + " is dead. Hitpoints dropped to " + _hitPoints);
            }
        }

        public List<object> BackPack = new List<object>();

        public void PickupItem(object attackOrDefence)
        {
            BackPack.Add(attackOrDefence);
        }

        public override string ToString()
        {
            var items =
                from ditem in BackPack
                where ditem.Equals(_defenceObject.MinDefence > 0)
                select ditem;

            var aitems =
                from aitem in BackPack
                where aitem.Equals(_attackObject.MinDamage > 0)
                select aitem;

            return $"Creature {Name}: READY TO FIGHT";
        }

        #endregion

        #region Template
        //protected override void AttackObjectList(List<AttackObject> attackObjects)
        //{
        //    attackObjects.Add(new AttackObject("Knife", new Position(2, 2), true, true, 5, 15));
        //    attackObjects.Add(new AttackObject("Pocket knife", new Position(2, 3), true, true, 2, 9));
        //    attackObjects.Add(new AttackObject("Sword", new Position(2, 4), true, true, 15, 25));
        //}
        #endregion
    }
}