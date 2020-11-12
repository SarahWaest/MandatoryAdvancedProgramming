namespace Mandatory_AdvancedProgramming.Objects.AbstractFactory
{
    public abstract class ICreature
    {
        public abstract IHero CreateHero();
        public abstract IEnemy CreatEnemy();
    }
}