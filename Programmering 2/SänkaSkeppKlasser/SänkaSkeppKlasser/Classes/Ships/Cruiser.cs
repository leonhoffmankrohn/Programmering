using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkeppKlasser.Classes.Ships
{
    // 3 rutor, näst störst
    class Cruiser : Ship
    {
        public Cruiser() 
        { 
            Length = 3;
        }
        public override string ToString()
        {
            return "cruiser";
        }
    }
}
