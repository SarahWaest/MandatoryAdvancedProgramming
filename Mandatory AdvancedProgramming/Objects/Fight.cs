namespace Mandatory_AdvancedProgramming.Objects
{
    public class Fight
    {
        private Creature creature = null;
        private EvilCreature evilCreature = null;

        public Fight()
        {
            InitialFighting(evilCreature);
        }

        public void InitialFighting(EvilCreature evilCreatureOpponent)
        {
            while (!creature.Dead && !evilCreatureOpponent.Dead)
            {
                creature.DealDamage();
                evilCreatureOpponent.ReceiveDamage(creature.DealDamage());
                while (!evilCreatureOpponent.Dead)
                {
                    evilCreatureOpponent.DealDamage();
                    creature.ReceiveDamage(evilCreatureOpponent.DealDamage());
                }
            }
        }
    }
}