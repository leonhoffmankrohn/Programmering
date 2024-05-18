using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkeppKlasser.Classes
{
    public class Shot
    {
        public int[] XY { get; }
        public Consequence Action {  get; set; }
        public Shot() { }

        public Shot(int _x, int _y, Consequence _action = Consequence.None)
        {
            XY = new int[2];
            XY[0] = _x;
            XY[1] = _y;
            Action = _action;
        }
    }
    public enum Consequence
    {
        None,
        ShotMissed,
        ShotHit
    }
}
