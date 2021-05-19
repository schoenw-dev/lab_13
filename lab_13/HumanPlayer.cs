using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13
{
    public class HumanPlayer : IPlayer
    {
        public string Name { get; set; }
        public RPS Play { get; set; }

        public string userInput;
        public RPS userNum;


        public HumanPlayer()
        {

        }

        public HumanPlayer(string _name)
        {
            Name = _name;
        }


        public void NamePlayer(string _name)
        {
            _name = Name;

        }

        public void ParseInput(string userInput)
        {
            if (userInput == "r")
            {
                userNum = RPS.Rock;
            }
            else if (userInput == "p")
            {
                userNum = RPS.Paper;
            }
            else if (userInput == "s")
            {
                userNum = RPS.Scissors;
            }
        }


        public RPS GenerateRPS()
        {
            ParseInput(userInput);
            return userNum;
        }
    }
}