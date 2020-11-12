using System.Threading.Channels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Mandatory_AdvancedProgramming.Factory;
using Mandatory_AdvancedProgramming.Objects;
using Mandatory_AdvancedProgramming.Objects.Attack;
using Mandatory_AdvancedProgramming.Objects.Defence;
using Mandatory_AdvancedProgramming.World;

namespace _2D_Game
{
   public class TestGame
    {
        public void Start()
        {
            World world = new World(30, 20);
            world.AssignChar();
            world.DrawWorld();

            AttackObject Sword = new AttackObject("Great Sword", new Position(1, 1),15,25,true );
            DefenceObject Shield = new DefenceObject("Thor", new Position(1, 1), 10,20, true);
            Creature Knight = new Creature("Knight", 0, 100, new Position(6, 8), Shield, Sword);
            Knight.DealDamage();
            Creature DarkKnight = new Creature("DarkKnight", 0, 100, new Position(5, 9), Shield, Sword);

            DarkKnight.ReceiveDamage(50);
            Knight.ReceiveDamage(100);
        }
    }
}