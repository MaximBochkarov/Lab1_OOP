using System;
using System.Collections.Generic;

namespace Lab1_Bochkarov
{
    public class GameAccount
    {
        private string UserName { get; }
        
        private int _currentRating;
        public int CurrentRating
        {
            get => _currentRating < 1 ? 1 : _currentRating;
            private set => _currentRating = value;
        }

        private const int InitialRating = 100;
        
        private readonly List<HistoryGame> _allStats = new List<HistoryGame>();
        

        public GameAccount(string userName)
        {
            UserName = userName;
            CurrentRating = InitialRating;
        }
        public void WinGame(Game game, GameAccount opponent)
        {
            Console.WriteLine($"Player {UserName} beat {opponent.UserName}, +{game.Rating} points");
            _allStats.Add(new HistoryGame(opponent, game.Rating, game.GameIndex, GameStatus.Win));
            CurrentRating += game.Rating;
        }
        public void LoseGame(Game game, GameAccount opponent)
        {
            Console.WriteLine($"Player {UserName} lose to {opponent.UserName}, -{game.Rating} points");
            _allStats.Add(new HistoryGame(opponent, game.Rating, game.GameIndex, GameStatus.Lose));
            CurrentRating -= game.Rating;
        }
        public void GetStats()
        {
            int gameNumber = 1;
            Console.WriteLine($"(<-The game history for: {UserName}->)");
            Console.WriteLine($"Total games: {_allStats.Count}, current rating: {CurrentRating}");
            foreach(var game in _allStats)
            {
                Console.Write($"Game number: {gameNumber++} --> \t");
                Console.WriteLine(game.GameStatus.Equals(GameStatus.Win)
                    ? $"Win against {game.Opponent.UserName},\t game rating: {game.Rating},\t index: {game.GameIndex}"
                    : $"Lose against {game.Opponent.UserName},\t game rating: {game.Rating},\t index: {game.GameIndex}");
            }
            
        }

    }
}