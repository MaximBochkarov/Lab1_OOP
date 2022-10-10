using System;
using System.Collections.Generic;

namespace Lab1_Bochkarov
{
    public class GameAccount
    {
        private string UserName { get; }
        public int CurrentRating { get; private set; }
        private int GamesCount { get; set; }
        
        public List<Game> AllStats = new List<Game>();

        public GameAccount(string UserName, int CurrentRating)
        {
            this.UserName = UserName;
            this.CurrentRating = CurrentRating;
            GamesCount = 0;
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
            foreach(var game in AllStats)
            {
                Console.Write($"Game number: {gameNumber++} --> \t");
                Console.WriteLine(UserName.Equals(game.Winner.UserName)
                    ? $"Win against {game.Looser.UserName},\t game rating: {game.Rating},\t index: {game.GameIndex}"
                    : $"Lose against {game.Winner.UserName},\t game rating: {game.Rating},\t index: {game.GameIndex}");
            }
            
        }
        
        
        
    }
}