using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkeppKlasser.Classes.Ships
{
    // 2 rutor, näst minst
    class Torpedo : Ship
    {
        public Torpedo()
        {
            Length = 2;
        }
    }
}
