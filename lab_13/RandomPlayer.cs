using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13
{
    public class RandomPlayer : IPlayer
    {
        public string Name { get; set; }


        Array randomPlays = Enum.GetValues(typeof(RPS));

        public RandomPlayer()
        {

        }

        public RandomPlayer(string _name)
        {
            Name = _name;
        }

        public RPS RandomRPSTypes()
        {
            Random rnd = new Random();
            RPS[] values = (RPS[])Enum.GetValues(typeof(RPS));
            return (RPS)values[rnd.Next(values.Length)];
        }


        public RPS GenerateRPS()
        {
            RPS play = RandomRPSTypes();
            Console.WriteLine($"{Name}: {play}");
            return play;
        }
    }
}