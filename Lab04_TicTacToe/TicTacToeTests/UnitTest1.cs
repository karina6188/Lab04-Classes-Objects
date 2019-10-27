using Lab04_TicTacToe.Classes;
using System;
using Xunit;
using static Lab04_TicTacToe.Program;

namespace TicTacToeTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestWinners()
        {
            string name1 = "Karina";
            string name2 = "Amanda";
            Player player1 = new Player($"{ name1 }(player 1)", "X");
            Player player2 = new Player($"{ name2 }(player 2)", "O");
            Game game = new Game(player1, player2);

            game.Board.GameBoard = new string[,]
            {
                {"1", "O", "3"},
                {"X", "O", "X"},
                {"X", "O", "9"},
            };

            Assert.Equal($"{ name1 }(player 1)", game.Play().Name);
        }

        [Fact]
        public void TestSwitchPlayer()
        {
            string name1 = "Karina";
            string name2 = "Amanda";
            Player player1 = new Player($"{ name1 }(player 1)", "X");
            Player player2 = new Player($"{ name2 }(player 2)", "O");
            Game game = new Game(player1, player2);

            game.Board.GameBoard = new string[,]
            {
                {"1", "O", "3"},
                {"X", "O", "6"},
                {"X", "O", "9"},
            };

            Assert.Equal($"{ name2 }(player 2)", game.NextPlayer().Name);
        }


        [Fact]
        public void TestSwitchAnotherPlayer()
        {
            string name1 = "Karina";
            string name2 = "Amanda";
            Player player1 = new Player($"{ name1 }(player 1)", "X");
            Player player2 = new Player($"{ name2 }(player 2)", "O");
            Game game = new Game(player1, player2);

            game.Board.GameBoard = new string[,]
            {
                {"Q", "O", "X"},
                {"X", "5", "6"},
                {"X", "O", "X"},
            };

            Assert.Equal($"{ name2 }(player 2)", game.NextPlayer().Name);
        }

        [Fact]
        public void TestBoardPosition()
        {
            string name1 = "Karina";
            string name2 = "Amanda";
            Player player1 = new Player($"{ name1 }(player 1)", "X");
            Player player2 = new Player($"{ name2 }(player 2)", "O");
            Game game = new Game(player1, player2);

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
