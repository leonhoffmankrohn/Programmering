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
            Player player = Player.One;
            Game game = new Game();

            bool run = true;
            while (run)
            {
                Console.WriteLine("Vill du spela en runda Tre-I-Rad? - y/n/q");
                char answer = Console.ReadKey().KeyChar;
                Console.WriteLine();

                bool gameOver = false;

                while ( answer == 'y' && !gameOver)
                {
                    Choice();
                    CurrentPlayer();
                }
            }

            bool Choice()
            {
                char row = '1';
                char col = '1';


                bool question = true;
                while (question)
                {
                    Console.WriteLine("Spelare var vänlig att ange en rad. 1/2/3/q");
                    row = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    if (row == 'q') Environment.Exit(0);
                    else if (int.Parse(row.ToString()) < 4 && int.Parse(row.ToString()) > 0) question = false;
                }

                question = true;
                while (question)
                {
                    Console.WriteLine("Spelare var vänlig att ange en kolumn. 1/2/3/q");
                    col = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    if (col == 'q') Environment.Exit(0);
                    else if (int.Parse(col.ToString()) < 4 && int.Parse(col.ToString()) > 0) question = false;
                    else Console.WriteLine("Du får försöka igen: \r\n");
                }

                return game.CheckChoice(int.Parse(row.ToString()), int.Parse(col.ToString()), player);
            }

            void CurrentPlayer() { player = (player == Player.One) ? Player.Two : Player.One; }

            Environment.Exit(0);
        }
    }
}
