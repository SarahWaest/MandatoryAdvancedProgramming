namespace Mandatory_AdvancedProgramming.Objects.AbstractFactory
{
    public abstract class IWeapons
    {
        public abstract IHero CreateHero();
        public abstract IEnemy CreatEnemy();
    }
}