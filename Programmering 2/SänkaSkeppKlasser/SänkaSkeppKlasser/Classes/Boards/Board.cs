using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkeppKlasser
{
    public class Board
    {
        public Cell[,] cells { set; get; }

        public Board(CellStatus setup)
        {
            cells = new Cell[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    cells[i, j] = new Cell();
                }
            }
        }

        // Ändrar cellens status
        public void ChangeCell(int x, int y, CellStatus status)
        {
            cells[x, y].Status = status;
        }
    }
}
