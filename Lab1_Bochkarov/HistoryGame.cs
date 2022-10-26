namespace Lab1_Bochkarov
{
    public class HistoryGame
    {
        public int Rating { get; }
        public GameAccount Opponent { get; }
        public int GameIndex { get; }
        public GameStatus GameStatus{get;}

        public HistoryGame(GameAccount opponent, int rating, int gameIndex, GameStatus gameStatus)
        {
            Opponent = opponent;
            Rating = rating;
            GameIndex = gameIndex;
            GameStatus = gameStatus;
        }
    }
}