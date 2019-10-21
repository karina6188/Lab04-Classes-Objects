using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

        /// <summary>
        /// Print out the board into console window by printing out the the columns for first row,
        /// then the second row, then the third row.
        /// </summary>
		public void DisplayBoard()
		{
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                for (int x = 0; x < GameBoard.GetLength(1); x++)
                {
                    Console.Write($"|{GameBoard[i,x]}|\n");
                }
            }
		}
	}
}
