using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTicTacToe
{
    public class TicTacToe
    {
        private int[,] board;
        private int nDimesions;
        /// <summary>
        /// Created a Tic Tac Tow game board
        /// </summary>
        /// <param name="n">nxn dimension for the game board</param>
        public TicTacToe(int n)
        {
            this.board = new int[n, n];
            this.nDimesions = n;
        }

        /// <summary>
        /// Util method to print out the board grid
        /// </summary>
        public string returnBoardState()
        {
            var returnString = "";
           for(int i = 0; i < this.nDimesions; i++)
            {
                for(int j = 0; j < this.nDimesions; j++)
                {
                    returnString += this.board[i, j] + " ";
                }
                returnString += "\n";
            }
            return returnString;
        }

        /// <summary>
        /// Place a piece on the game board
        /// </summary>
        /// <param name="row">row to place a piece</param>
        /// <param name="col">column to place a piece</param>
        /// <param name="player">the player (1 or 2) the piece is for</param>
        /// <returns>0 = no winner, 1 = player 1 won, 2 = player 2 won</returns>
        public int PlacePiece(int row, int col, int player)
        {
            //make move
            this.board[row, col] = player;
            
            //check if is winner
            var iCol = 0;
            var iRow = 0;
            var iDiag = 0;
            var iRDiag = 0;;

            for(int i = 0; i < this.nDimesions; i++)
            {
                if (this.board[row, i] == player) iCol++;
                if (this.board[i, col] == player) iRow++;
                if (this.board[i, i] == player) iDiag++;
                if (this.board[i, nDimesions - i - 1] == player) iRDiag++;
                if (iCol == nDimesions || iRow == nDimesions || iDiag == nDimesions || iRDiag == nDimesions) return player;
            }
            return 0;
        }

    }
}
