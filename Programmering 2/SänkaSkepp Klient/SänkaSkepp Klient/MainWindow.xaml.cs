using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SänkaSkeppKlasser;
using SänkaSkeppKlasser.Classes;
using SänkaSkeppKlasser.Classes.Boards;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using UtilitiesLib;

namespace SänkaSkepp_Klient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    /*
     * Klienten bygger sin spelplan
     * Vi försöker att ansluta till hosten och skickar spelplanen
     * Väntar på drag från hosten.
     */
    public partial class MainWindow : Window
    {
        Button[,] playerButtons = new Button[10, 10];
        Button[,] enemyButtons = new Button[10, 10];
        Game game = new Game();
        TcpClient client = new TcpClient();
        bool yourturn = false;

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        // Intitieras i början och har en loop som gör att vattnet "rör" på sig
        async void Game()
        {
            stpEnemyBoard.Visibility = Visibility.Collapsed;
            ShipsStatus();
            while (true)
            {
                await Task.Delay(1000);
                UpdateBoards();
            }
        }
        
        // Skriver ut nästa steg
        bool ShipsStatus()
        {
            if (game.ships.Count > 0)
            {
                lblStatus.Content = "Placera ut en båt med längden " + game.ships[0].Length + "m";
                return true;
            }
            else
            {
                lblStatus.Content = "Nu ska du ansluta till hosten";
                ServerSetup();
                return false;
            }
        }

        // Sätter synligheten på servergrejen
        void ServerSetup()
        {
            stpPlayerBoard.Visibility = Visibility.Collapsed;
            wplStartServer.Visibility = Visibility.Visible;
        }

        // "poppar" nästa skepp
        bool PopNextShip()
        {
            game.SelectedShip = game.ships[0];
            game.ships.RemoveAt(0);
            return ShipsStatus();
        }

        // Uppdaterar brädet och startar själva spelet
        void Initialize()
        {
            UpdateBoards();
            Game();
        }

        // Uppdaterar båda brädena
        void UpdateBoards()
        {
            stpPlayer.Children.Clear();
            stpEnemy.Children.Clear();
            PopulateBoard(game.player, stpPlayer, playerButtons, YouBoard_Click);
            PopulateBoard(game.enemy, stpEnemy, enemyButtons, EnemyBoard_Click);
        }

        // Populerar brädorna med färgade knappar motsvaranade olika cellstatus, har också en random på vatten
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
                            buttonArray[x, y] = new Button() { Background = Brushes.Gray };
                            break;

                        case CellStatus.Water:
                            Random random = new Random();
                            int variable = Math.Abs(random.Next() * 10) % 3;
                            if (variable == 0) buttonArray[x, y] = new Button() { Background = new SolidColorBrush(Color.FromArgb(180, (byte)0, (byte)10, (byte)245)) };
                            else if (variable == 1) buttonArray[x, y] = new Button() { Background = new SolidColorBrush(Color.FromArgb(180, (byte)0, (byte)20, (byte)235)) };
                            else if (variable == 2) buttonArray[x, y] = new Button() { Background = new SolidColorBrush(Color.FromArgb(180, (byte)0, (byte)30, (byte)225)) };
                            else buttonArray[x, y] = new Button() { Background = Brushes.Red };
                            break;

                        case CellStatus.Boat:
                            buttonArray[x, y] = new Button() { Background = Brushes.SaddleBrown };
                            break;

                        case CellStatus.HitBoat:
                            buttonArray[x, y] = new Button() { Background = Brushes.Red };
                            break;

                        case CellStatus.MissedBoat:
                            buttonArray[x, y] = new Button() { Background = Brushes.White };
                            break;
                    }
                    buttonArray[x, y].Height = 30;
                    buttonArray[x, y].Width = 30;
                    buttonArray[x, y].Click += clickevent;
                    buttonArray[x, y].BorderThickness = new Thickness(0);

                    row.Children.Add(buttonArray[x, y]);
                }
                panel.Children.Add(row);
            }
        }

        // Returnerar en xy-array på kordinater varpå den hittar knappen som blev tryckt i en multiarray av knappar, returnerar [-1, -1] ifall den inte hittade / fel spelbräde
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
       
        // Kollar ifall en båt kan placeras, om det bara är vatten
        bool AllIsWater(int startX, int startY, int length, bool horisontal, Board board)
        {
            bool justwater = true;
            if (horisontal)
            {
                for (int i = startX; i < startX + length; i++)
                {
                    if (board.cells[i, startY].Status != CellStatus.Water) { justwater = false; }
                }
            }
            else
            {
                for (int i = startY; i < startY + length; i++)
                {
                    if (board.cells[startX, i].Status != CellStatus.Water) { justwater = false; }
                }
            }
            return justwater;
        }

        // Kollar ifall båten kan placeras innanför spelbrädet
        bool FitInArea(int startX, int startY, int length, bool horisontal)
        {
            switch (horisontal)
            {
                case true:
                    if (startX + length <= 10) return true;
                    break;
                case false:
                    if (startY + length <= 10) return true;
                    break;
            }
            return false;
        }

        // Lägger båten i spelplanen
        void AddBoat(int startX, int startY, int length, bool horisontal, Board board)
        {
            switch (horisontal)
            {
                case true:
                    for (int i = 0; i < length; i++)
                    {
                        board.ChangeCell(startX + i, startY, CellStatus.Boat);
                    }
                    break;
                case false:
                    for (int i = 0; i < length; i++)
                    {
                        board.ChangeCell(startX, startY + i, CellStatus.Boat);
                    }
                    break;
            }
        }

        // Placerar båten i spelplanen
        void PlaceBoat(object sender, Board board, Button[,] buttons)
        {
            bool boatsLeft = true;
            try
            {
                int[] indecies = FindIndex(buttons, (sender as Button));
                int length = game.ships[0].Length;
                bool horisontal = (bool)chcBoxHorisontal.IsChecked;

                if (indecies[0] > -1 && FitInArea(indecies[0], indecies[1], length, horisontal) && AllIsWater(indecies[0], indecies[1], length, horisontal, board))
                {
                    boatsLeft = PopNextShip();
                    AddBoat(indecies[0], indecies[1], length, horisontal, board);
                }
                else MessageBox.Show("Try placing it somewhere else");
                UpdateBoards();

            }
            catch (Exception e) { MessageBox.Show(e.Message); }

            if (!boatsLeft)
            {
                game.State = GameState.Running;
            }
        }

        void GameStarted()
        {
            lblStatus.Content = "Waiting for the opponent to attack...";
        }
        async void SendShot(Shot shot)
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(shot);
                byte[] message = Encoding.Unicode.GetBytes(jsonString);
                await client.GetStream().WriteAsync(message);
                ShotListener();
            }
            catch (Exception ex) { MessageBox.Show("Host not found"); }
        }

        async void PlayerAction(object sender)
        {
            switch (game.State)
            {
                case GameState.SetUp:
                    PlaceBoat(sender, game.player, playerButtons);
                    break;
                case GameState.Running:
                    int[] indecies = FindIndex(enemyButtons, sender);
                    if (indecies[0] != -1 && yourturn)
                    {
                        yourturn = false;
                        lblStatus.Content = "Waiting for opponent to attack...";
                        SendShot(new Shot(indecies[0], indecies[1]));
                        ShotListener();
                    }
                    break;
                default:
                    break;
            }
        }

        private void YouBoard_Click(object sender, RoutedEventArgs e)
        {
            PlayerAction(sender);
        }

        private void EnemyBoard_Click(object sender, RoutedEventArgs e)
        {
            PlayerAction(sender);
        }

        async void ShotListener()
        {
            if (client != null)
            {
                try
                {
                    Debug.WriteLine("Shotlistener");
                    byte[] indata = new byte[999];
                    int antalbyte = await client.GetStream().ReadAsync(indata, 0, indata.Length);
                    string data = Encoding.Unicode.GetString(indata, 0, antalbyte);
                    Shot shot = JsonConvert.DeserializeObject<Shot>(data);

                    switch (shot.Responseshot)
                    {
                        case true:
                            InterperateShot(shot, game.enemy);
                            break;
                        case false:
                            InterperateShot(shot, game.player);
                            lblStatus.Content = "Your turn to shot at the enemy!";
                            break;
                    }

                    yourturn = true;
                    InterperateGameState(shot.GOandWinner);
                }
                catch (Exception ex) { MessageBox.Show("Host not found"); }
            }
        }

        void GameOver(bool whowon)
        {
            Debug.WriteLine("Game over");
            lblStatus.Content = (whowon) ? "GameOver, you lost..." : "GameOver, You won!";
            GetFacit();
        }

        async void GetFacit()
        {
            try
            {
                byte[] indata = new byte[9999999];
                int antalbyte = await client.GetStream().ReadAsync(indata, 0, indata.Length);
                string data = Encoding.Unicode.GetString(indata, 0, antalbyte);

                game.enemy.cells = JsonConvert.DeserializeObject<Cell[,]>(data);
                MessageTimer("Here is the opponents board", 5000);
            }
            catch (Exception ex) { MessageBox.Show("Host not found"); }
        }

        void InterperateGameState(bool[] data)
        {
            if (data[0])
            {
                game.State = GameState.GameOver;
                GameOver((data[1]));
            }
        }

        void InterperateShot(Shot shot, Board board)
        {
            int x = shot.XY[0];
            int y = shot.XY[1];
            switch (shot.Action)
            {
                case Consequence.ShotMissed:
                    board.cells[x, y].Status = CellStatus.MissedBoat;
                    break;
                    
                case Consequence.ShotHit:
                    board.cells[x,y].Status = CellStatus.HitBoat;
                    break;
            }
        }

        async void ServerSet()
        {
            client = new TcpClient();

            while (!client.Connected)
            {
                try
                {
                await client.ConnectAsync(IPAddress.Parse(tbxHostIP.Text), int.Parse(tbxHostPort.Text));
                }
                catch { }
            }


            string jsonString = JsonConvert.SerializeObject(game.player.cells);

            byte[] message = Encoding.Unicode.GetBytes(jsonString);
            await client.GetStream().WriteAsync(message);

            stpPlayerBoard.Visibility = Visibility.Visible;
            stpEnemyBoard.Visibility = Visibility.Visible;
            wplStartServer.Visibility = Visibility.Collapsed;

            ShotListener();
            GameStarted();
        }

        private void btnConnectToHost_Click(object sender, RoutedEventArgs e)
        {
            btnConnectToHost.IsEnabled = false;
            ServerSet();
        }

        async void MessageTimer(string message, int timeinm)
        {
            string before = lblStatus.Content.ToString();
            lblStatus.Content = message;
            await Task.Delay(timeinm);
            lblStatus.Content = (lblStatus.Content == message) ? before : lblStatus.Content;
        }
    }
}