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
                run = Choice();
            }

            bool Choice()
            {
                Console.WriteLine("Vill du spela en runda Tre-I-Rad? - y/n/q");
                char answer = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (answer == 'y')
                {
                    bool question = true;
                    while (question)
                    {
                        Console.WriteLine("Spelare var vänlig att ange en rad. 1/2/3/q");
                        char row = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        if (row == 'q') Environment.Exit(0);
                        else if (int.Parse(row.ToString()) < 4 && int.Parse(row.ToString()) > 0) question = false;
                    }

                    question = true;
                    while (question)
                    {
                        Console.WriteLine("Spelare var vänlig att ange en kolumn. 1/2/3/q");
                        char col = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        if (col == 'q') Environment.Exit(0);
                        else if (int.Parse(col.ToString()) < 4 && int.Parse(col.ToString()) > 0) question = false;
                        else Console.WriteLine("Du får försöka igen: \r\n");
                    }
                }
                else if (answer == 'n' || answer == 'q') return false;
                return true;
            }

            bool CurrentPlayer()
            {
                return false;
            }

            Environment.Exit(0);
        }
    }
}
