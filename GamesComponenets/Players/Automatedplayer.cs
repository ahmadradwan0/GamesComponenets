using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamesComponenets.Choices;
using GamesComponenets.Scores;

namespace GamesComponenets.Players
{
    public class Automatedplayer : IPlayer
    {

           
        private IChoise _choise;
        private IScore _score;
        public Automatedplayer(IChoise choise, IScore score)
        {
            _choise = choise;
            _score = score;
        }

        public IChoise choise()
        {
            return _choise;
        }

        public IScore score()
        {
            return _score;
        }

        public int Deficultylevel()
        {

            return 0;
        }
    }
}
