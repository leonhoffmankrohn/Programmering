using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player;
            Game game = new Game();

            bool run = true;
            while (run)
            {
                Console.WriteLine("Vill du spela en runda Tre-I-Rad? - y/n");
                char answer = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (answer == 'y')
                {

                }
                else if (answer == 'n') run = false;
            }

            bool Choice()
            {
                return false;
            }

            bool CurrentPlayer()
            {
                return false;
            }
        }
    }
}
