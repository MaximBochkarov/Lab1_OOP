using System;

namespace Lab1_Bochkarov
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GameAccount player1 = new GameAccount("Thomas");
            GameAccount player2 = new GameAccount("Harry");
            
            Game game1 = new Game(player1, player2, 8);
            game1.Play();
            Console.WriteLine("<---------------------------------------------------->");
            Game game2 = new Game(player1, player2, 20);
            game2.Play();
            Console.WriteLine("<---------------------------------------------------->");
            Game game3 = new Game(player1, player2, 5);
            game3.Play();
            Console.WriteLine("<---------------------------------------------------->");
            Game game4 = new Game(player1, player2, 100);
            game4.Play();
            Console.WriteLine("<---------------------------------------------------->");
            Game game5 = new Game(player1, player2, 25);
            game5.Play();
            Console.WriteLine("<---------------------------------------------------->");
            
            player1.GetStats();
            Console.WriteLine("<---------------------------------------------------->");
            player2.GetStats();
        }
    }
}