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
            Player player = Player.Ett;
            int[] score = new int[] { 0, 0 };
            Game game;
            bool run = true;
            // Denna loop kommer att köras om hela tiden tills spelare indikerar att stänga ner
            while (run)
            {
                Console.WriteLine("Vill du spela en runda Tre-I-Rad? - y/n/q");
                char answer = Console.ReadKey().KeyChar;
                Console.WriteLine();

                bool noWinner = false;
                bool gameOver = false;
                if (answer == 'q' || answer == 'n') Environment.Exit(0);

                Console.Clear();
                game = new Game();

                // Den här kommer att köra ett helt spel
                while ( answer == 'y' && !gameOver)
                {
                    bool success = Choice();
                    gameOver = game.CheckWinner(out noWinner);

                    if (gameOver || noWinner) break;
                    else if (success) CurrentPlayer();
                    else
                    {
                        Console.WriteLine("Jag tror det blev något fel där... prova igen spelare " + player.ToString().ToLower());
                    }
                }
                
                if (noWinner)
                {
                    Console.WriteLine("Bra spelat, det belv dock oavgjort");
                }
                else
                {
                    Console.WriteLine("Bra spelat, spelare " + player.ToString().ToLower() + " vann!\n\r");
                    score[(int)player-1]+=1;
                    Console.WriteLine("Spelare ett: " + score[0] + " poäng\n\rSpelare två: " + score[1] + " poäng.");
                }

            }

            // Här ber vi spelaren om en rad och en kolumn
            bool Choice()
            {
                char row = '1';
                char col = '1';


                bool question = true;
                while (question)
                {
                    Console.WriteLine("Spelare " + player.ToString().ToLower() + " var vänlig att ange en rad. 1/2/3/q");
                    row = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    if (row == 'q') Environment.Exit(0);
                    // Lägg till elseifsats som tryparsear skiten
                    else if (!char.IsDigit(row)) Console.WriteLine("Var vänlig att skriva ett tal");
                    else if (int.Parse(row.ToString()) < 4 && int.Parse(row.ToString()) > 0) question = false;
                }

                question = true;
                while (question)
                {
                    Console.WriteLine("Spelare " + player.ToString().ToLower() + " var vänlig att ange en kolumn. 1/2/3/q");
                    col = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    if (col == 'q') Environment.Exit(0);
                    // Lägg till elseifsats som tryparsear skiten
                    else if (!char.IsDigit(col)) Console.WriteLine("Var vänlig att skriva ett tal");
                    else if (int.Parse(col.ToString()) < 4 && int.Parse(col.ToString()) > 0) question = false;
                    else Console.WriteLine("Du får försöka igen: \r\n");
                }

                return game.CheckChoice(int.Parse(row.ToString()), int.Parse(col.ToString()), player);
            }

            // Här byter vi spelare
            void CurrentPlayer() { player = (player == Player.Ett) ? Player.Två : Player.Ett; }

            Environment.Exit(0);
        }
    }
}
