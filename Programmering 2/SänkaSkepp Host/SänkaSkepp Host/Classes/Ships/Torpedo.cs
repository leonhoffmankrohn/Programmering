using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkepp_Host.Classes.Ships
{
    // 2 rutor, näst minst
    class Torpedo : Ship
    {
        int Length { get; set; }

        public Torpedo()
        {
            
        }
    }
}
