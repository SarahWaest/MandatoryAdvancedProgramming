namespace Mandatory_AdvancedProgramming.Objects.Defence
{
    public class Shield : DefenceObject
    {
        public Shield(string name, Position position,  int minDamage, int maxDamage, bool enchanced)
            : base(name, position, minDamage, maxDamage, enchanced)
        {
        }
    }
}