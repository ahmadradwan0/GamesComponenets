using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesComponenets.Choices
{
    public class ManualConsoleChoise : IChoise
    {
        public string doTheChoise()
        {
            Console.WriteLine("player Enter the Code : ");
            return Console.ReadLine();

        }

    }
}
