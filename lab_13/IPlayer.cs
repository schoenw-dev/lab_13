using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13
{
    public interface IPlayer
    {
        public string Name { get; set; }




        public RPS GenerateRPS();


    }
}
