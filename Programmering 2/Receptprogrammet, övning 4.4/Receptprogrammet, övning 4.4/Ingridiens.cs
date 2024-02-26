using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptprogrammet__övning_4._4
{
    internal class Ingridiens
    {
        public string Namn { get; set; }
        public float Mängd { get; set; }
        public string Mått { get; set; }
        public Ingridiens(string _namn, float _mängd, string _mått)
        {
            Namn = _namn;
            Mängd = _mängd;
            Mått = _mått;
        }

        public override string ToString()
        {
            return Namn + " " + Mängd + " " + Mått;
        }
    }
}
