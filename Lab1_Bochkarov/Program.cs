using System;

namespace Lab1_Bochkarov
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GameAccount player1 = new GameAccount("Thomas");
            GameAccount player2 = new GameAccount("Harry");
            GameAccount player3 = new GameAccount("Bober");
            
            Game game1 = new Game(player1, player2, 10);
            game1.Play();
            Console.WriteLine("<---------------------------------------------------->");
            Game game2 = new Game(player1, player2, 20);
            game2.Play();
            Console.WriteLine("<---------------------------------------------------->");
            Game game3 = new Game(player1, player2, -5);
            game3.Play();
            Console.WriteLine("<---------------------------------------------------->");
            Game game4 = new Game(player1, player2, 100);
            game4.Play();
            Console.WriteLine("<---------------------------------------------------->");
            Game game5 = new Game(player1, player2, 25);
            game5.Play();
            Console.WriteLine("<---------------------------------------------------->");
            Game game6 = new Game(player1, player3, 12);
            game6.Play();
            Console.WriteLine("<---------------------------------------------------->");
            Game game7 = new Game(player2, player3, 14);
            game7.Play();
            Console.WriteLine("<---------------------------------------------------->");
            
            player1.GetStats();
            Console.WriteLine("<---------------------------------------------------->");
            player2.GetStats();
            Console.WriteLine("<---------------------------------------------------->");
            player3.GetStats();
        }
    }
}