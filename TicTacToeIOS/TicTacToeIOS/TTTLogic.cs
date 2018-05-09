using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeIOS
{
    class TTTLogic
    {
        private static string[,] board = new string[3, 3];
        private static int winningSelection;
        private static string winner, winningOrientation;

        static TTTLogic()
        {
            Reset();
        }

        public static string Winner
        {
            get { return winner; }
        }

        public static string WinningOrientation
        {
            get { return winningOrientation; }
        }

        public static int WinningSelection
        {
            get { return winningSelection; }
        }

        public static void PlayerMove(string buttonName)
        {

            int row = int.Parse(buttonName.Split(',')[0]), col = int.Parse(buttonName.Split(',')[1]);
            board[row, col] = "O";
        }

        public static string ComputerMove()
        {
            Random rng = new Random();
            int row, col;
            do
            {
                row = rng.Next(3);
                col = rng.Next(3);
            } while (board[row, col] != "");
            board[row, col] = "X";
            return row.ToString() + "," + col.ToString();
        }

        public static void Reset()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    board[r, c] = "";
                }
            }
            winningSelection = -1;
            winningOrientation = "";
        }

        public static bool IsRowWinner(int row)
        {
            if (board[row, 0] == board[row, 1]
                && board[row, 1] == board[row, 2]
                && board[row, 0] != "")
            {
                winningOrientation = "row";
                winningSelection = row;
                return true;
            }
            else
                return false;
        }

        public static bool IsAnyRowWinner()
        {
            return IsRowWinner(0) || IsRowWinner(1) || IsRowWinner(2);
        }

        public static bool IsColumnWinner(int col)
        {
            if (board[0, col] == board[1, col]
                && board[1, col] == board[2, col]
                && board[0, col] != "")
            {
                winningOrientation = "column";
                winningSelection = col;
                return true;
            }
            else
                return false;
        }

        public static bool IsAnyColumnWinner()
        {
            return IsColumnWinner(0) || IsColumnWinner(1) || IsColumnWinner(2);
        }

        public static bool IsDiagonal1Winner()
        {
            if (board[0, 0] == board[1, 1] &&
                board[1, 1] == board[2, 2] &&
                board[0, 0] != "")
            {
                winningOrientation = "diagonal1";
                return true;
            }
            else
                return false;
        }

        public static bool IsDiagonal2Winner()
        {
            if (board[0, 2] == board[1, 1] &&
                board[1, 1] == board[2, 0] &&
                board[0, 2] != "")
            {
                winningOrientation = "diagonal2";
                return true;
            }
            else
                return false;

        }

        public static bool IsAnyDiagonalWinner()
        {
            if (IsDiagonal1Winner())
            {
                return true;
            }
            else if (IsDiagonal2Winner())
            {
                return true;
            }
            else
                return false;

        }

        public static bool IsWinner()
        {
            return IsAnyRowWinner() ||
            IsAnyColumnWinner() ||
            IsAnyDiagonalWinner();
        }

        public static bool IsFull()
        {
            for (int row = 0; row < 3; row++)
                for (int col = 0; col < 3; col++)
                    if (board[row, col] == "")
                        return false;
            return true;

        }

        public static bool IsTie()
        {
            return (IsFull() && !(IsWinner()));
        }
    }
}
