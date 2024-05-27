using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkeppKlasser.Classes.Ships
{
    // Den minsta på en ruta
    class Submarine : Ship
    {
        public Submarine()
        {
            Length = 1;
        }
    }
}
