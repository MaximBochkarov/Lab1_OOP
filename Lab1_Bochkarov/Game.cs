using System;

namespace Lab1_Bochkarov
{
    public class Game
    {
        private static Random _rand = new Random();
        private static int _gameIndexSeed = 123455;
        private GameAccount acc1, acc2;
        public GameAccount Winner { get; set; }
        public GameAccount Looser { get; set; }
        public int GameIndex { get; }
        public int Rating { get; set; }
        
        public Game(GameAccount acc1, GameAccount acc2, int Rating)
        {
            this.acc1 = acc1;
            this.acc2 = acc2;
            RatingCheck(Rating);
            GameIndex = _gameIndexSeed;
            Winner = null;
            Looser = null;
            _gameIndexSeed++;
        }
        
        public void Play()
        {
            if (acc1.CurrentRating - Rating < 1 || acc2.CurrentRating - Rating < 1)
            {
                Console.WriteLine($"Player rating can not be lower than 1");
                return;
            }
            Console.WriteLine($"Game index: {GameIndex}");
            int decide = _rand.Next(1, 3);

            if (decide == 1)
            {
                Winner = acc1;
                Looser = acc2;
                acc1.WinGame(Looser, Rating);
                acc2.LoseGame(Winner, Rating);
            }
            else
            {
                Winner = acc2;
                Looser = acc1;
                acc2.WinGame(Looser, Rating);
                acc1.LoseGame(Winner, Rating);
            }
            acc1.AllStats.Add(this);
            acc2.AllStats.Add(this);
        }

        private void RatingCheck(int rating)
        {
            if(rating < 0)
                throw new ArgumentOutOfRangeException(nameof(rating),"Amount of rating must be positive");
            Rating = rating;
        }
    }
}