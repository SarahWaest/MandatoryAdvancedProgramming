using System;
using Mandatory_AdvancedProgramming.Objects;
using Mandatory_AdvancedProgramming.Objects.Attack;

namespace Mandatory_AdvancedProgramming.Factory
{
    public class EnemyCreatureTempate : EvilCreature
    {
        private static string cd = "";
        private static Random random = new Random();

        public override EvilCreature CreateEvilCreature(string creaturePick)
        {
            cd = creaturePick;
            if (cd == "EnemyCreature")
            {
                return new EvilCreature(100, "Monster", new AttackObject("Axe", 10,20, false ));
            }
            if (cd == "Boss")
            {
                return new EvilCreature(100, "BossCreature", new AttackObject("DualSwords", 15, 50, false));
            }
            else
            {
                throw new NotImplementedException("Type EnemyCreature");
            }
        }
    }
}