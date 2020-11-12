using System;
using System.Collections.Generic;

namespace Mandatory_AdvancedProgramming.Objects
{
    public class BattleLog
    {
        private static List<string> _log = new List<string>();

        /// <summary>
        /// Save a single string
        /// </summary>
        public static void Save(string message)
        {
            _log.Add(message);
        }

        /// <summary>
        /// Print out all the strings saved in the log
        /// </summary>
        public void PrintLog()
        {
            Console.WriteLine("Battle log :");
            Console.WriteLine("======================================");
            foreach (string s in _log)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// Clear all strings from the log
        /// </summary>
        public static void Reset()
        {
            _log.Clear();
        }
    }
}