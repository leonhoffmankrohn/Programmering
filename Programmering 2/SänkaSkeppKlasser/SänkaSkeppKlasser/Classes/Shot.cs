﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkeppKlasser.Classes
{
    public class Shot
    {
        public int[] XY = new int[2];
        public Consequence Action {  get; set; }
        public bool Responseshot { get; set; }
        public bool[] GOandWinner { get; set; }
        public Shot(int _x, int _y, Consequence _action = Consequence.None, bool _responseshot = false, bool _gameOver = false, bool _hostwon = false)
        {
            XY[0] = _x;
            XY[1] = _y;
            Action = _action;
            Responseshot = _responseshot;
            GOandWinner = [_gameOver, _hostwon];
        }
    }
    public enum Consequence
    {
        None,
        ShotMissed,
        ShotHit
    }
}
