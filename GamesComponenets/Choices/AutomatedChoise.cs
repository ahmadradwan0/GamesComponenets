using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesComponenets.Choices
{
    public class AutomatedChoice : IChoise
    {
        private Random random;

        public AutomatedChoice()
        {
            random = new Random();
        }

        public string doTheChoise()
        {
            int randomNumber = random.Next(1, 4); // Generates a random number between 1 and 3

            switch (randomNumber)
            {
                case 1:
                    return "R"; // Rock
                case 2:
                    return "P"; // Paper
                case 3:
                    return "S"; // Scissors
                default:
                    throw new InvalidOperationException("Unexpected random number . . .");
            }
        }
    }

}
