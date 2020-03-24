using Lab04_TicTacToe.Classes;
using System;
using Xunit;
using static Lab04_TicTacToe.Program;

namespace TicTacToeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CheckWinners()
        {
            Player player1 = new Player($"Karina", "X");
            Player player2 = new Player($"Amanda", "O");
            Game game = new Game(player1, player2);

            game.Board.GameBoard = new string[,]
            {
                {"1", "2", "X"},
                {"4", "X", "6"},
                {"X", "8", "9"},
            };

            bool outcome = game.CheckForWinner(game.Board);

            Assert.True(outcome);
        }

        [Fact]
        public void StartGame()
        {
            Player player1 = new Player($"Karina", "X");
            Player player2 = new Player($"Amanda", "O");
            Game game = new Game(player1, player2);

            game.Board.GameBoard = new string[,]
            {
                {"1", "O", "3"},
                {"X", "O", "X"},
                {"X", "O", "9"},
            };

            Assert.Equal($"Karina", game.Play().Name);
        }

        [Fact]
        public void TestSwitchPlayer()
        {
            Player player1 = new Player($"Karina", "X");
            Player player2 = new Player($"Amanda", "O");
            Game game = new Game(player1, player2);

            game.Board.GameBoard = new string[,]
            {
                {"1", "O", "3"},
                {"X", "O", "6"},
                {"X", "O", "9"},
            };

            Assert.Equal($"Amanda", game.NextPlayer().Name);
        }

        [Fact]
        public void TestSwitchAnotherPlayer()
        {
            Player player1 = new Player($"Karina", "X");
            Player player2 = new Player($"Amanda", "O");
            Game game = new Game(player1, player2);

            game.Board.GameBoard = new string[,]
            {
                {"Q", "O", "X"},
                {"X", "5", "6"},
                {"X", "O", "X"},
            };

            Assert.Equal($"Amanda", game.NextPlayer().Name);
            Assert.Equal($"Karina", game.PlayerOne.Name);
        }

        [Fact]
        public void TestBoardPosition()
        {
            Game game = new Game(new Player($"Karina", "X"), new Player($"Amanda", "O"));

            game.Board.GameBoard = new string[,]
            {
                {"O", "2", "O"},
                {"O", "X", "6"},
                {"7", "X", "9"},
            };
            Assert.Equal(new Position(1, 1).Column, Player.PositionForNumber(5).Column);
            Assert.Equal(new Position(1, 1).Row, Player.PositionForNumber(5).Row);
        }
    }
}
