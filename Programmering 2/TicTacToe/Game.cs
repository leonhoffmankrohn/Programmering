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
        }
        private void Drawboard()
        {
            
        }

        public bool CheckChoice( int row, int column, Player playerturn)
        {
            return false;
        }

        public bool CheckWinner()
        {
            return false;
        }
    }
}
