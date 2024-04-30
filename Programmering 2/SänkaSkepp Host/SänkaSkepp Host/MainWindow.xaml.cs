using SänkaSkepp_Host.Classes.Boards;
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
        PlayerBoard player = new PlayerBoard();
        EnemyBoard enemy = new EnemyBoard();
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            UpdateBoards();
        }

        void UpdateBoards()
        {
            stpPlayer.Children.Clear();
            stpEnemy.Children.Clear();
            PopulateBoard(player, stpPlayer);
            PopulateBoard(enemy, stpEnemy);
        }

        void PopulateBoard(Board board, StackPanel panel) 
        {
            for (int i = 0; i < board.cells.GetLength(0); i++)
            {
                WrapPanel row = new WrapPanel();

                for (int j = 0; j < board.cells.GetLength(1); j++)
                {
                    switch (board.cells[i, j].Status)
                    {
                        case CellStatus.Unknown:
                            playerButtons[i,j] = new Button() { Background = Brushes.Gray};
                            break;

                        case CellStatus.Water:
                            playerButtons[i, j] = new Button() { Background = Brushes.Aqua };
                            break;

                        case CellStatus.Boat:
                            playerButtons[i, j] = new Button() { Background = Brushes.SaddleBrown };
                            break;

                        case CellStatus.HitBoat:
                            playerButtons[i, j] = new Button() { Background = Brushes.IndianRed };
                            break;
                    }
                    playerButtons[i, j].Height = 30;
                    playerButtons[i, j].Width = 30;
                    playerButtons[i, j].Click += YouBoard_Click;
                    row.Children.Add(playerButtons[i,j]);
                }
                panel.Children.Add(row);
            }
        }

        int[] FindIndex(object[,] array, object obj)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == obj)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { -1, -1 };
        }

        void PlaceBoat(object sender)
        {
            try
            {
                int[] indecies = FindIndex(playerButtons, (sender as Button)); // något fel i metoden?
                int length = (int)sliShipLength.Value;
                if (chcBoxHorisontal.IsChecked == true && indecies[0] + length - 1 < 10 && indecies[0] > -1)
                {
                    for (int i = 0; i < length; i++)
                    {
                        // playerBoard[indecies[0] + i, indecies[1]].Background = Brushes.Black;
                        player.cells[indecies[0] + i, indecies[1]].Status = CellStatus.Boat;
                    }
                }
                else if (chcBoxHorisontal.IsChecked == false && indecies[1] + length - 1 < 10 && indecies[0] > -1)
                {
                    for (int i = 0; i < length; i++)
                    {
                        // playerBoard[indecies[0], indecies[1] + i].Background = Brushes.Black;
                        player.cells[indecies[0], indecies[1] + i].Status = CellStatus.Boat;
                    }
                }
                else MessageBox.Show("Try placing it somewhere else");
                UpdateBoards();

            }
            catch (Exception e){ MessageBox.Show(e.Message); }
        }

        private void YouBoard_Click(object sender, RoutedEventArgs e)
        {
            PlaceBoat(sender);
        }


    }
}