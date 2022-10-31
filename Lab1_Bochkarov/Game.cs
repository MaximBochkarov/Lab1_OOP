using System;

namespace Lab1_Bochkarov
{
    public class Game
    {
        private static readonly Random Rand = new Random();
        private static int _gameIndexSeed = 38256;
        private readonly GameAccount acc1, acc2;
        public int GameIndex { get; set; }
        public int Rating { get; }
        
        public Game(GameAccount acc1, GameAccount acc2, int rating)
        {
            this.acc1 = acc1;
            this.acc2 = acc2;
            Rating = rating;
        }
        
        public void Play()
        {
            try
            {
                CheckNegativeRating(Rating);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught starting game with negative rating");
                Console.WriteLine(e.ToString());
                return;
            }
            if (acc1.CurrentRating - Rating < 1 || acc2.CurrentRating - Rating < 1)
            {
                Console.WriteLine($"Game rating is too high. Player`s rating can not be lower than 1");
                return;
            }

            GameIndex = GetNextInd();
            
            Console.WriteLine($"Game index: {GameIndex}");
            int decide = Rand.Next(1, 3);

            if (decide == 1)
            {
                AssignStatusWinner(acc1, acc2);
            }
            else
            {
                AssignStatusWinner(acc2, acc1);
            }
        }

        private void AssignStatusWinner(GameAccount winner, GameAccount looser)
        {
            winner.WinGame(this ,looser);
            looser.LoseGame(this ,winner);
        }
        
        private static int GetNextInd() => ++_gameIndexSeed;     
        private static void CheckNegativeRating(int rating)
        {
            if(rating < 0)
                throw new ArgumentOutOfRangeException(nameof(rating),"Amount of rating must be positive");
        }
    }
}