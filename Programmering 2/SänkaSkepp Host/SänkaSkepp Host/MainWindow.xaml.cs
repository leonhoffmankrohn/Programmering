using SänkaSkeppKlasser.Classes;
using SänkaSkeppKlasser.Classes.Boards;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents.Serialization;
using System.Windows.Media;
using System.Xml.Serialization;
using Color = System.Windows.Media.Color;
using UtilitiesLib;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Windows.Documents;

namespace SänkaSkeppKlasser
{
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
        Game game = new Game();
        Board actualEnemy = new Board(CellStatus.Unknown);
        TcpClient client = new TcpClient();
        bool yourturn = true;

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        // Körs i början och är en loop, ger upphov till att havet rör på sig
        async void AutoBoardUpdate()
        {
            while (true)
            {
                await Task.Delay(1000);
                UpdateBoards();
            }
        }

        // Kör några nödvändiga funktioner för början
        void Initialize()
        {
            UpdateBoards();
            AutoBoardUpdate();
        }

        // Visar vad nästa steg är
        bool ShipsStatus()
        {
            if (game.ships.Count > 0)
            {
                lblStatus.Content = "Placera ut en båt med längden " + game.ships[0].Length + "m";
                return true;
            }
            else
            {
                lblStatus.Content = "Initiering klar";
                return false;
            }
        }

        // "Poppar" nästa skepp i listan
        bool PopNextShip()
        {
            game.SelectedShip = game.ships[0];
            game.ships.RemoveAt(0);
            return ShipsStatus();
        }

        // Tar bort och lägger till knappar i brädena
        void UpdateBoards()
        {
            stpPlayer.Children.Clear();
            stpEnemy.Children.Clear();
            PopulateBoard(game.player, stpPlayer, playerButtons, YouBoard_Click);
            PopulateBoard(game.enemy, stpEnemy, enemyButtons, EnemyBoard_Click);
        }

        // Populerar de "fysiska" brädena med datan och celler
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

                        case CellStatus.MissedBoat:
                            buttonArray[x, y] = new Button() { Background = Brushes.White };
                            break;

                        case CellStatus.HitBoat:
                            buttonArray[x, y] = new Button() { Background = Brushes.Red };
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

        // Returnerar vilken kordinat man hittar obj i den multidimensionella listan
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

        // Kollar ifall allt verkligen är vatten där båten ska placeras
        bool AllIsWater(int startX, int startY, int length, bool horisontal, Board board)
        {
            bool justwater = true;
            if (horisontal)
            {
                for (int i = startX; i < startX + length; i++)
                {
                    if ((Surrounded(i, startY, board)) || (board.cells[i, startY].Status != CellStatus.Water)) { justwater = false; }
                }
            }
            else
            {
                for (int i = startY; i < startY + length; i++)
                {
                    if ((Surrounded(startX, i, board)) || (board.cells[startX, i].Status != CellStatus.Water)) { justwater = false; }
                }
            }
            return justwater;
        }

        // Kollar ifall det finns båtar i närheten
        bool Surrounded(int stx, int sty, Board board)
        {
            bool surrounded = false;

            for (int x = stx-1; x <= stx+1; x++)
            {
                for (int y = sty-1; y <= sty+1; y++)
                {
                    if(((x < 10) && (x > -1)) && ((y < 10) && (y > -1)))
                    {
                        if (board.cells[x, y].Status == CellStatus.Boat) surrounded = true;
                    }
                }
            }

            return surrounded;
        }

        // Kollar ifall båten är innanför ramen av brädet
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

        // Lägger till en båt på brädet
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

        // Överläggande logik innan båt läggs till, kollar också om det är slut på båtar
        void PlaceBoat(object sender, Board board, Button[,] buttons)
        {
            bool boatsLeft = true; // Här kan man ändra gamestate om den returnerar false, alltså det finns inga fler kvar
            try
            {
                int[] indecies = FindIndex(buttons, (sender as Button));
                int length = game.ships[0].Length;
                bool horisontal = (bool)chcBoxHorisontal.IsChecked;

                if (indecies[0] > -1 && FitInArea(indecies[0], indecies[1], length, horisontal) && AllIsWater(indecies[0], indecies[1], length, horisontal, board))
                {
                    MessageTimer("Placed a " + game.ships[0].ToString(), 2000);
                    boatsLeft = PopNextShip();
                    AddBoat(indecies[0], indecies[1], length, horisontal, board);
                }
                else MessageTimer("Try placing it somewhere else", 5000);
                UpdateBoards();

            }
            catch (Exception e) { MessageBox.Show(e.Message); }

            if (!boatsLeft)
            {
                game.State = GameState.Running;
                GameStarted();
            }
        }

        // Kärs när spelet ska startas (när det är slut på båtar)
        void GameStarted()
        {
            stpEnemyBoard.Visibility = Visibility.Visible;
            stpPlayerBoard.Visibility = Visibility.Visible;
            lblStatus.Content = "Your turn to shot at the enemy!";
        }

        // Generar ett skott från kordinat
        void Fire(int x, int y)
        {
            CellStatus whatsBeenHit = actualEnemy.cells[x, y].Status;
            switch (whatsBeenHit)
            {
                case CellStatus.Water:
                    game.enemy.cells[x, y].Status = CellStatus.MissedBoat;
                    actualEnemy.cells[x, y].Status = CellStatus.MissedBoat;
                    SendShot(new Shot(x, y, Consequence.ShotMissed));
                    break;

                case CellStatus.Boat:
                    game.enemy.cells[x, y].Status = CellStatus.HitBoat;
                    actualEnemy.cells[x, y].Status = CellStatus.HitBoat;
                    SendShot(new Shot(x, y, Consequence.ShotHit));
                    break;

            }
        }

        // Skickar skottet till motståndaren, och kollar ifall spelet är slut
        async void SendShot(Shot shot)
        {
            try
            {
                if (CheckIfGameOver(out bool youWon))
                {
                    game.State = GameState.GameOver;
                    shot.GOandWinner = [true, youWon];
                    string jsonString = JsonConvert.SerializeObject(shot);
                    byte[] message = Encoding.Unicode.GetBytes(jsonString);
                    await client.GetStream().WriteAsync(message);
                    GameOver(youWon);
                }
                else
                {
                    string jsonString = JsonConvert.SerializeObject(shot);
                    byte[] message = Encoding.Unicode.GetBytes(jsonString);
                    await client.GetStream().WriteAsync(message);
                }
            }
            catch (Exception ex) { MessageBox.Show("Client disconnected"); }
        }

        // Lyssnar på skott från motståndaren
        async void ShotListener()
        {
            try
            {
                byte[] indata = new byte[999];
                int antalbyte = await client.GetStream().ReadAsync(indata, 0, indata.Length);
                string data = Encoding.Unicode.GetString(indata, 0, antalbyte);
                Shot shot = JsonConvert.DeserializeObject<Shot>(data);
                yourturn = true;
                lblStatus.Content = "Your turn to shot at the enemy!";
                InterperateShot(shot);
            }
            catch (Exception ex) { MessageBox.Show("Client disconnected"); }

        }

        // Tyder vad motståndarens kordinater på skott ger för skada och skickar tillbaka informationen till motståndaren
        void InterperateShot(Shot shot)
        {
            int x = shot.XY[0];
            int y = shot.XY[1];
            if (game.player.cells[x, y].Status == CellStatus.Water) shot.Action = Consequence.ShotMissed;
            else if (game.player.cells[x, y].Status == CellStatus.Boat) shot.Action = Consequence.ShotHit;
            switch (shot.Action)
            {
                case Consequence.ShotMissed:
                    game.player.cells[x, y].Status = CellStatus.MissedBoat;
                    break;

                case Consequence.ShotHit:
                    game.player.cells[x, y].Status = CellStatus.HitBoat;
                    break;
            }
            shot.Responseshot = true;
            SendShot(shot);
        }

        // Kollar ifall brädena har några levande båtar kvar, annars är spelet över
        bool CheckIfGameOver(out bool youWon)
        {
            bool gameOver = true;
            bool gm1 = true;
            bool gm2 = true;
            Board board = game.player;
            for (int x = 0; x < board.cells.GetLength(0); x++)
            {
                for (int y = 0; y < board.cells.GetLength(1); y++)
                {
                    if (board.cells[x, y].Status == CellStatus.Boat) gm1 = false;
                }
            }
            board = actualEnemy;
            for (int x = 0; x < board.cells.GetLength(0); x++)
            {
                for (int y = 0; y < board.cells.GetLength(1); y++)
                {
                    if (board.cells[x, y].Status == CellStatus.Boat) gm2 = false;
                }
            }
            gameOver = (gm1 != gm2);
            youWon = (gm1 == false) ? true : false;
            return gameOver;
        }

        // Körs varje knapptryckbrädtryck och beroende på bräde och spelstadje, placerar båt eller skjuter
        void PlayerAction(object sender)
        {
            
            switch (game.State)
            {
                case GameState.SetUp:
                    PlaceBoat(sender, game.player, playerButtons);
                    break;
                case GameState.Running:
                    if (client.Connected)
                    {
                        int[] indecies = FindIndex(enemyButtons, sender);
                        if (indecies[0] != -1 && yourturn)
                        {
                            lblStatus.Content = "Waiting for opponent to attack...";
                            Fire(indecies[0], indecies[1]);
                            ShotListener();
                            yourturn = false;
                        }
                    }
                    else MessageTimer("Waiting for client to connect...", 1000);
                    break;
                default:
                    break;
            }
            UpdateBoards();
        }

        // Kärs när spelet är slutspelat
        void GameOver(bool youWon)
        {
            Debug.WriteLine("Game over");
            lblStatus.Content = (youWon) ? "GameOver! You Won!" : "GameOver, you lost...";
            game.enemy.cells = actualEnemy.cells;
            SendFacit();
        }

        // Skickar facit på spelplanen till motståndaren
        async void SendFacit()
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(game.player.cells);
                byte[] message = Encoding.Unicode.GetBytes(jsonString);
                await client.GetStream().WriteAsync(message);
            }
            catch (Exception ex) { MessageBox.Show("Client disconnected"); }
        }

        // När eget spelbräde blir klickat
        private void YouBoard_Click(object sender, RoutedEventArgs e)
        {
            PlayerAction(sender);
        }

        // När själv trycker på motståndarens bräde
        private void EnemyBoard_Click(object sender, RoutedEventArgs e)
        {
            PlayerAction(sender);
        }

        // Initierar en server i början och väntar på att opponent ansluter
        async void ServerSet(int port)
        {
            MessageTimer("Server started at " + port + ", waiting for opponent...", 2500);
            try
            {
                TcpListener server = new TcpListener(IPAddress.Any, port);
                server.Start();

                await Task.Delay(3000);
                client = await server.AcceptTcpClientAsync();
                if (client.Connected) MessageTimer("Opponent has connected!", 5000);

                byte[] indata = new byte[9999999];
                int antalbyte = await client.GetStream().ReadAsync(indata, 0, indata.Length);
                string data = Encoding.Unicode.GetString(indata, 0, antalbyte);

                actualEnemy.cells = JsonConvert.DeserializeObject<Cell[,]>(data);
            }
            catch (Exception ex) { MessageBox.Show("Client disconnected"); }
            UpdateBoards();
        }

        // Startar igång servern
        private void btnStartServer_Click(object sender, RoutedEventArgs e)
        {
            ShipsStatus();
            stpPlayerBoard.Visibility = Visibility.Visible;
            wplStartServer.Visibility = Visibility.Collapsed;

            int.TryParse(tbxHostPort.Text, out int port);
            ServerSet(port);
        }

        // Visar ett temporärt meddelande
        async void MessageTimer(string message, int timeinm)
        {
            string before = lblStatus.Content.ToString();
            lblStatus.Content = message;
            await Task.Delay(timeinm);
            lblStatus.Content = (lblStatus.Content == message) ? before : lblStatus.Content;
        }

    }
}