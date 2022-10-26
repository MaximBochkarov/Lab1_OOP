using System;
using System.Collections.Generic;

namespace Lab1_Bochkarov
{
    public class GameAccount
    {
        private string UserName { get; }
        public int CurrentRating { get; private set; }
        private int GamesCount { get; set; }
        
        private const int InitialRating = 100;
        
        private readonly List<HistoryGame> _allStats = new List<HistoryGame>();

        public GameAccount(string userName)
        {
            UserName = userName;
            CurrentRating = InitialRating;
            GamesCount = 0;
        }
        public void AddHistoryGame(HistoryGame historyGame)
        {
            _allStats.Add(historyGame);
        }

        public void WinGame(GameAccount opponent, int rating)
        {
            Console.WriteLine($"Player {UserName} beat {opponent.UserName}, +{rating} points");
            CurrentRating += rating;
            GamesCount += 1;
        }
        public void LoseGame(GameAccount opponent, int rating)
        {
            Console.WriteLine($"Player {UserName} lose to {opponent.UserName}, -{rating} points");
            CurrentRating -= rating;
            GamesCount += 1;
        }
        public void GetStats()
        {
            int gameNumber = 1;
            Console.WriteLine($"(<-The game history for: {UserName}->)");
            Console.WriteLine($"Total games: {GamesCount}, current rating: {CurrentRating}");
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