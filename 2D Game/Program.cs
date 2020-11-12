using System;
using Mandatory_AdvancedProgramming.Objects;
using Mandatory_AdvancedProgramming.World;

namespace _2D_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            TestGame testGame = new TestGame();
            testGame.Start();
            BattleLog battleLog = new BattleLog();
            battleLog.PrintLog();
            Console.WriteLine();

            Console.WriteLine("Program is done");
            Console.ReadKey();
        }
    }
}
