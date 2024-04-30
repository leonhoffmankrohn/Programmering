using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkepp_Host
{
    class Cell
    {
        public CellStatus Status { get; set; }
        public Cell(CellStatus _status = CellStatus.Water) 
        { 
            Status = _status;
        }
    }

    enum CellStatus
    {
        Unknown = 0,
        Water = 1,
        Boat = 2,
        HitBoat = 3,
    }
}
