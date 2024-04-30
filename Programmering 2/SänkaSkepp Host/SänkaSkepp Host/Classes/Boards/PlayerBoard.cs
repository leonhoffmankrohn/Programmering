using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkepp_Host.Classes.Boards
{
    class PlayerBoard : Board
    {
        public PlayerBoard() : base(CellStatus.Water)
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    cells[i, j] = new Cell(CellStatus.Water);
                }
            }
        }
    }
}
