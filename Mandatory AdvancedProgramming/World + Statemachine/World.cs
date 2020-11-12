using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Mandatory_AdvancedProgramming.Objects;
using Mandatory_AdvancedProgramming.Objects.Attack;
using Mandatory_AdvancedProgramming.Objects.Defence;

namespace Mandatory_AdvancedProgramming.World
{
    public class World
    {
        private static int _worldheigt = 19;
        private static int _worldwidth = 38;
        private char[,] _playground = new char[_worldheigt, _worldwidth];


        public void RegisterWorldItems()
        {

        }

        public World(int height, int width)
        {
            _worldheigt = height;
            _worldwidth = width;
        }

        public void DrawWorld()
        {
            for (int i = 0; i < _playground.GetLength(0); i++)
            {
                for (int j = 0; j < _playground.GetLength(1); j++)
                {
                    Console.SetCursorPosition(i,j);
                    Console.Write(_playground[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void AssignChar()
        {
            _playground = new char[_worldheigt, _worldwidth];

            for (int i = 0; i < _playground.GetLength(0); i++)
            {
                _playground[i, 0] = 'X';
                var t =_playground.GetLength(1) - 1;
                _playground[i, _playground.GetLength(1) - 1] = 'X';
                for (int j = 0; j < _playground.GetLength(1); j++)
                {
                    _playground[0, j] = 'X';
                    _playground[_playground.GetLength(0) - 1, j] = 'X';
                }
            }
        }
    }
}