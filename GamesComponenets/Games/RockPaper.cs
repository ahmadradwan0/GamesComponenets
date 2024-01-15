using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using GamesComponenets.Players;

namespace GamesComponenets.Games
{
    public class RockPaper : IGameMechanism
    {
        private IPlayer _player1;
        private IPlayer _player2;

        public RockPaper(IPlayer p1, IPlayer p2)
        {
            _player1 = p1;
            _player2 = p2;
        }
        public void play()
        {
            char cp1 = char.Parse(_player1.choise().doTheChoise());
            char cp2 = char.Parse(_player2.choise().doTheChoise());

            if (cp1 == cp2)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (cp1 == 'R' && cp2 == 'S' ||
                     cp1 == 'P' && cp2 == 'R' ||
                     cp1 == 'S' && cp2 == 'P')
            {

                Console.WriteLine("Player 1 wins!");
            }
            else
            {
                Console.WriteLine("Player 2 wins!");
            }




        }

    }
}
