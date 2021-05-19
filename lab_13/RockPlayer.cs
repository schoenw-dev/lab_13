using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13
{
    public class RockPlayer : IPlayer
    {
        public string Name { get; set; }

        public RockPlayer()
        {

        }

        public RockPlayer(string _name)
        {
            Name = _name;
        }

        public RPS GenerateRPS()
        {
            Console.WriteLine($"{Name}: {RPS.Rock}");
            return RPS.Rock;

        }
    }
}