﻿using SänkaSkeppKlasser.Classes;
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

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        async void AutoBoardUpdate()
        {
            while (true)
            {
                await Task.Delay(1000);
                UpdateBoards();
            }
        }

        void Initialize()
        {
            UpdateBoards();
            AutoBoardUpdate();
        }

        bool ShipsStatus()
        {
            if (game.ships.Count > 0)
            {
                lblStatus.Content = "Placera ut en båt med längden " + game.ships[0].Length + "m";
                return true;
            }
            else
            {
                lblStatus.Content = "Inväntar spelare";
                game.State = GameState.Running;
                return false;
            }
        }

        bool PopNextShip()
        {
            game.SelectedShip = game.ships[0];
            game.ships.RemoveAt(0);
            return ShipsStatus();
        }

        void UpdateBoards()
        {
            stpPlayer.Children.Clear();
            stpEnemy.Children.Clear();
            PopulateBoard(game.player, stpPlayer, playerButtons, YouBoard_Click);
            PopulateBoard(game.enemy, stpEnemy, enemyButtons, EnemyBoard_Click);
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
                    boatsLeft = PopNextShip();
                    AddBoat(indecies[0], indecies[1], length, horisontal, board);
                }
                else MessageBox.Show("Try placing it somewhere else");
                UpdateBoards();

            }
            catch (Exception e) { MessageBox.Show(e.Message); }

            if (!boatsLeft)
            {
                game.State = GameState.SetUpDone;
            }
        }

        void PlayerAction(object sender)
        {
            switch (game.State)
            {
                case GameState.SetUp:
                    PlaceBoat(sender, game.player, playerButtons);
                    break;
                case GameState.Running:
                    int[] indecies = FindIndex(enemyButtons, sender);
                    if (indecies[0] != -1)
                    {
                        Fire(indecies[0], indecies[1]);
                    }
                    break;
                default:
                    break;
            }
        }

        void Fire(int x, int y)
        {
            CellStatus whatsBeenHit = actualEnemy.cells[x, y].Status;
            switch (whatsBeenHit)
            {
                case CellStatus.Water:
                    game.enemy.cells[x, y].Status = whatsBeenHit;
                    SendShot(new Shot(x, y, Consequence.ShotMissed));
                    break;

                case CellStatus.Boat:
                    game.enemy.cells[x, y].Status = CellStatus.HitBoat;
                    break;

            }
        }

        async void SendShot(Shot shot)
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(shot);
                byte[] message = Encoding.Unicode.GetBytes(jsonString);

                await client.GetStream().WriteAsync(message);
            }
            catch (Exception ex) { }
        }

        async void ShotListener()
        {
            while (game.State == GameState.Running)
            {
                try
                {
                    byte[] indata = new byte[9999999];
                    int antalbyte = await client.GetStream().ReadAsync(indata, 0, indata.Length);
                    string data = Encoding.Unicode.GetString(indata, 0, antalbyte);
                    Shot shot = JsonConvert.DeserializeObject<Shot>(data);
                    InterperateShot(shot);
                }
                catch (Exception ex) { }
            }
        }

        void InterperateShot(Shot shot)
        {
            int x = shot.XY[0];
            int y = shot.XY[1];
            if (game.player.cells[x, y].Status == CellStatus.Boat)
            {
                shot.Action = Consequence.ShotHit;
                game.player.cells[x, y].Status = CellStatus.HitBoat;
            }
            else
            {
                shot.Action = Consequence.ShotMissed;
                game.player.cells[x, y].Status = CellStatus.MissedBoat;
            }

            SendShot(shot);
        }


        private void YouBoard_Click(object sender, RoutedEventArgs e)
        {
            PlayerAction(sender);
        }

        private void EnemyBoard_Click(object sender, RoutedEventArgs e)
        {
            PlayerAction(sender);
        }

        async void ServerSet(int port)
        {
            bool connected = false;
            lblStatus.Content = "Waiting for opponent...";
            try
            {
                TcpListener server = new TcpListener(IPAddress.Any, port);
                server.Start();

                client = await server.AcceptTcpClientAsync();
                if (client.Connected) lblStatus.Content = "Opponent has connected!";

                byte[] indata = new byte[9999999];
                int antalbyte = await client.GetStream().ReadAsync(indata, 0, indata.Length);
                string data = Encoding.Unicode.GetString(indata, 0, antalbyte);

                actualEnemy.cells = JsonConvert.DeserializeObject<Cell[,]>(data);
                }
            catch (Exception ex) { }
            UpdateBoards();
        }

        private void btnStartServer_Click(object sender, RoutedEventArgs e)
        {
            lblStatus.Content = "Server started at port " + tbxHostPort.Text;
            stpPlayerBoard.Visibility = Visibility.Visible;
            wplStartServer.Visibility = Visibility.Collapsed;

            int.TryParse(tbxHostPort.Text, out int port);
            ServerSet(port);
        }
    }
}