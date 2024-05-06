using SänkaSkepp_Host.Classes.Boards;
using SänkaSkepp_Host.Classes.Ships;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SänkaSkepp_Host
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    /*
     * Låta hosten göra sin spelplan
     * När klienten ansluter börjar hosten sitt första drag
     * draget evalureras och skickas till klienten
     * klienten skickar sitt drag och det evalueras på hosten och skickas tillbaka
     */
    public partial class MainWindow : Window
    {
        Button[,] playerButtons = new Button[10, 10];
        Button[,] enemyButtons = new Button[10, 10];
        PlayerBoard player = new PlayerBoard();
        EnemyBoard enemy = new EnemyBoard();

        List<Ship> ships = new List<Ship>() { new Battleship(), new Cruiser(), new Cruiser(), new Torpedo(), new Torpedo(), new Torpedo(), new Submarine(), new Submarine(), new Submarine(), new Submarine() };

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        void Game()
        {
            while (true)
            {
                PlaceAllBoats();
            }
        }

        void PlaceAllBoats()
        {
            StackPanel enemy = (stpEnemy.Parent as GroupBox).Parent as StackPanel;
            enemy.Visibility = Visibility.Collapsed;
        }

        void Initialize()
        {
            UpdateBoards();
        }

        void UpdateBoards()
        {
            stpPlayer.Children.Clear();
            stpEnemy.Children.Clear();
            PopulateBoard(player, stpPlayer, playerButtons, YouBoard_Click);
            PopulateBoard(enemy, stpEnemy, enemyButtons, EnemyBoard_Click);
        }

        void PopulateBoard(Board board, StackPanel panel, Button[,] buttonArray, RoutedEventHandler clickevent)
        {
            for (int y = 0; y < board.cells.GetLength(0); y++)
            {
                WrapPanel row = new WrapPanel();

                for (int x = 0; x < board.cells.GetLength(1); x++)
                {
                    switch (board.cells[x, y].Status)
                    {
                        case CellStatus.Unknown:
                            buttonArray[x, y] = new Button() { Background = Brushes.Gray};
                            break;

                        case CellStatus.Water:
                            buttonArray[x, y] = new Button() { Background = Brushes.Aqua };
                            break;

                        case CellStatus.Boat:
                            buttonArray[x, y] = new Button() { Background = Brushes.SaddleBrown };
                            break;

                        case CellStatus.HitBoat:
                            buttonArray[x, y] = new Button() { Background = Brushes.IndianRed };
                            break;
                    }
                    buttonArray[x, y].Height = 30;
                    buttonArray[x, y].Width = 30;
                    buttonArray[x, y].Click += clickevent;
                    row.Children.Add(buttonArray[x,y]);
                }
                panel.Children.Add(row);
            }
        }

        int[] FindIndex(object[,] array, object obj)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    if (array[i, j] == obj)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { -1, -1 };
        }

        void PlaceBoat(object sender, Board board, Button[,] buttons)
        {
            try
            {
                int[] indecies = FindIndex(buttons, (sender as Button)); // något fel i metoden?
                Debug.WriteLine(indecies[0] + " : " + indecies[1]);
                int length = 3;
                if (chcBoxHorisontal.IsChecked == true && indecies[0] + length - 1 < 10 && indecies[0] > -1)
                {
                    for (int i = 0; i < length; i++)
                    {
                        board.ChangeCell(indecies[0] + i, indecies[1], CellStatus.Boat);

                    }
                }
                else if (chcBoxHorisontal.IsChecked == false && indecies[1] + length - 1 < 10 && indecies[0] > -1)
                {
                    for (int i = 0; i < length; i++)
                    {
                        board.ChangeCell(indecies[0], indecies[1]+i, CellStatus.Boat);
                    }
                }
                else MessageBox.Show("Try placing it somewhere else");
                UpdateBoards();

            }
            catch (Exception e){ MessageBox.Show(e.Message); }
        }

        private void YouBoard_Click(object sender, RoutedEventArgs e)
        {
            PlaceBoat(sender, player, playerButtons);
        }

        private void EnemyBoard_Click(object sender, RoutedEventArgs e)
        {
            PlaceBoat(sender, enemy, enemyButtons);
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Game();
        }
    }
}