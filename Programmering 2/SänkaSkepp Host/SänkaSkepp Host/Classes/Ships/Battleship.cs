using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkepp_Host.Classes.Ships
{
    // 4 rutor, störst
    class Battleship : Ship
    {
        public Battleship()
        {
            Length = 4;
        }
    }
}
