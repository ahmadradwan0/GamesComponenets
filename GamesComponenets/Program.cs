using GamesComponenets;
using GamesComponenets.Choices;
using GamesComponenets.Games;
using GamesComponenets.Players;
using GamesComponenets.Scores;

RockPaper rc = new RockPaper(new HumanPlayer(new ManualConsoleChoise(),new basicScore()), new Automatedplayer(new AutomatedChoice(), new basicScore()));

rc.play();