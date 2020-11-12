namespace Mandatory_AdvancedProgramming.Objects.Attack
{
    public class Sword : AttackObject
    {
        public Sword(string name, Position position, int minDamage, int maxDamage, bool enchanced)
            : base(name, position, minDamage, maxDamage, enchanced)
        {
        }
    }
}