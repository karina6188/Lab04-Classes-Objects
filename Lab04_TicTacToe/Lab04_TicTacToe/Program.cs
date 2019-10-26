using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreatePlayers();
        }

        /// <summary>
        /// Create instances for player 1 and player 2 and run the Game method.
        /// </summary>
        static void CreatePlayers()
        {
            Console.WriteLine("Let's play a tic-tac-toe game!");
            Console.WriteLine("Please enter player 1's name: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Please enter player 2's name: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Great! Let's start the game!\n");
            Player player1 = new Player($"{ name1 }(player 1)", "X");
            Player player2 = new Player($"{ name2 }(player 2)", "O");
            Game game = new Game(player2, player1);

            game.Play();
            Player winner = (game.Play());
            Console.WriteLine($"Congratulations!! {winner} won the game!");
        }

        // TODO: You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
    }
}
