using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Game
    {
        //Medlemsvariabler
        char[,] board = new char[3,3];
        
        //Metoder
        public Game()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = '-';
                }
            }

            Drawboard();
        }
        private void Drawboard()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---1-----2-----3---\n\r" +
                              "1  " + board[0, 0] + "  |  " + board[0, 1] + "  |  " + board[0, 2] + "  |\n\r" +
                              "|-----------------| \n\r" +
                              "2  " + board[1, 0] + "  |  " + board[1, 1] + "  |  " + board[1, 2] + "  |\n\r" +
                              "|-----------------| \n\r" +
                              "3  " + board[2, 0] + "  |  " + board[2, 1] + "  |  " + board[2, 2] + "  |\n\r" +
                              "-------------------");
            Console.ForegroundColor = ConsoleColor.White;

        }

        public bool CheckChoice( int row, int column, Player playerturn)
        {
            row--;column--;
            if (board[row, column] == '-')
            {
                if (playerturn == Player.Ett) board[row, column] = 'X';
                else if (playerturn == Player.Två) board[row, column] = 'O';
                Drawboard();
                return true;
            }
            else return false;
        }

        public bool CheckWinner()
        {
            bool win = false;
            for (int row = 0; row < 3; row++) if (board[row, 0] != '-' && board[row, 0] == board[row, 1] && board[row, 0] == board[row, 2])
                {
                    win = true;
                }
            for (int col = 0; col < 3; col++) if (board[0,col] != '-' && board[0, col] == board[1, col] && board[0, col] == board[2, col])
                {
                    win = true;
                }
            if ((board[0, 0].Equals(board[1,1]) && board[0, 0].Equals(board[2,2])) || 
                (board[0, 2].Equals(board[1,1]) && board[0, 2].Equals(board[2, 0])))
            {
                win = true;
            }
            return win;
        }
    }
}
