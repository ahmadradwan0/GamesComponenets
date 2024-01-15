using GamesComponenets;
using GamesComponenets.Games;
using GamesComponenets.Players;

RockPaper rc = new RockPaper(new HumanPlayer(new ManualConsoleChoise(),new basicScore()), new Automatedplayer(new AutomatedChoice(), new basicScore()));

rc.play();