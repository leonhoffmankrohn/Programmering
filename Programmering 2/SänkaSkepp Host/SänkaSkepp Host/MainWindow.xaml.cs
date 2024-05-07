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
using Color = System.Windows.Media.Color;

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
        Ship SelectedShip;

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        async void Game()
        {
            while (true)
            {
                await Task.Delay(1000);
                UpdateBoards();
            }
        }

        bool NextShip()
        {
            SelectedShip = ships[0];
            ships.RemoveAt(0);
            if (ships.Count > 0)
            {
                lblStatus.Text = "Placera ut en båt med längden " + SelectedShip.Length + "m";
                return true;
            }
            else
            {
                lblStatus.Text = "Nu är det slut på båtar att placera";
                return false;
            }
        }

        void Initialize()
        {
            NextShip();
            UpdateBoards();
            Game();
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
                            Random random = new Random();
                            int variable = Math.Abs(random.Next()*10) % 3;
                            Debug.WriteLine(variable);
                            if (variable == 0) buttonArray[x, y] = new Button() { Background = new SolidColorBrush(Color.FromArgb(180, (byte)0, (byte)10, (byte)245)) };
                            else if (variable == 1) buttonArray[x, y] = new Button() { Background = new SolidColorBrush(Color.FromArgb(180, (byte)0, (byte)20, (byte)235)) };
                            else if (variable == 2) buttonArray[x, y] = new Button() { Background = new SolidColorBrush(Color.FromArgb(180, (byte)0, (byte)30, (byte)225)) };
                            else buttonArray[x, y] = new Button() { Background = Brushes.Red };
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
                    buttonArray[x, y].BorderThickness = new Thickness(0);

                    row.Children.Add(buttonArray[x,y]);
                }
                panel.Children.Add(row);
            }
        }

        int[] FindIndex(object[,] array, object obj)
        {
            for (int x = 0; x < array.GetLength(1); x++)
            {
                for (int y = 0; y < array.GetLength(0); y++)
                {
                    if (array[x, y] == obj)
                    {
                        return new int[] { x, y };
                    }
                }
            }
            return new int[] { -1, -1 };
        }

        void PlaceBoat(object sender, Board board, Button[,] buttons, int length)
        {
            try
            {
                int[] indecies = FindIndex(buttons, (sender as Button)); // något fel i metoden?
                Debug.WriteLine(indecies[0] + " : " + indecies[1]);
                length = (length == 0) ? 3 : length;
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
            NextShip(); // Här kan man ändra gamestate om den returnerar false, alltså det finns inga fler kvar

        }

        private void YouBoard_Click(object sender, RoutedEventArgs e)
        {
            PlaceBoat(sender, player, playerButtons, 3);
        }

        private void EnemyBoard_Click(object sender, RoutedEventArgs e)
        {
            PlaceBoat(sender, enemy, enemyButtons, 3);
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Game();
        }
    }
}