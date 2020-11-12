using Mandatory_AdvancedProgramming.Objects.Attack;
using Mandatory_AdvancedProgramming.Objects.Defence;

namespace Mandatory_AdvancedProgramming.Objects
{
    public class EvilCreature
    {
        protected int _hitPoints;
        private string _name;
        private AttackObject _attackObject;

        public EvilCreature(int hitPoints, string name, AttackObject attackObject)
        {
            _hitPoints = hitPoints;
            _name = name;
            _attackObject = attackObject;
        }

        public EvilCreature()
        {
            
        }

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

        public int DealDamage()
        {
            return _attackObject.DealDamage();
        }

        public void ReceiveDamage(int damage)
        {
            int armor = 0;

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

        #region Template

        public abstract EvilCreature CreateEvilCreature(string creaturePick);

        #endregion
    }
}