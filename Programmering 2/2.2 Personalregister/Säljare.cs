using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Personalregister
{
    internal class Säljare : Anställd
    {
        double provision;
        double försäljning;

        public Säljare(string _namn, double _provision, double _försäljning) : base(_namn)
        {
            provision = _provision;
            försäljning = _försäljning;
        }

        public override double BeräknaLön()
        {
            return försäljning * provision / 100;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
