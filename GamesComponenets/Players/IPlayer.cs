using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamesComponenets.Choices;
using GamesComponenets.Scores;

namespace GamesComponenets.Players
{
    public interface IPlayer
    {

        public IChoise choise();

        public IScore score();

    }
}
