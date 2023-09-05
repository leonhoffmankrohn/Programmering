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

        public bool CheckWinner( out bool noWinner)
        {
            bool win = false;
            noWinner = true;

            for (int i = 0; i < 3; i++)
            {
                win = (board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2] && board[i, 0] != '-') ? true : false;
                win = (board[0, i] == board[1, i] && board[0, i] == board[2, i] && board[0, i] != '-') ? true : false;
            }
            if (board[1, 1] != '-')
            {
                win = (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2]) ? true : false;
                win = (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0]) ? true : false;
            }
            else
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        if (board[row, col] == '-')
                        {
                            noWinner = false;
                            break;
                        }
                    }
                    if (noWinner) break;
                }
            }
            return win;
        }
    }
}
