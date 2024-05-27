using SänkaSkeppKlasser.Classes.Boards;
using SänkaSkeppKlasser.Classes.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkeppKlasser.Classes
{
    public class Game
    {
        public GameState State {  get; set; }
        public PlayerBoard player = new PlayerBoard();
        public EnemyBoard enemy = new EnemyBoard();
        // public List<Ship> ships = new List<Ship>() { new Battleship(), new Cruiser(), new Cruiser(), new Torpedo(), new Torpedo(), new Torpedo(), new Submarine(), new Submarine(), new Submarine(), new Submarine() };
        public List<Ship> ships = new List<Ship>() { new Battleship(), new Submarine() };
        public Ship SelectedShip;

        public Game()
        {
            State = GameState.SetUp;
            SelectedShip = ships[0];
        }
    }

    public enum GameState
    {
        SetUp = 0,
        SetUpDone = 1,
        Running = 2,
        GameOver = 3,
    }
}
