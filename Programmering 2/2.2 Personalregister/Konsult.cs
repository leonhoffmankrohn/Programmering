using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Personalregister
{
    internal class Konsult : Anställd
    {
        double arbetadeTimmar;
        double timlön;

        public Konsult(string _namn, double _arbetadeTimmar, double _timLön) : base(_namn)
        {
            arbetadeTimmar = _arbetadeTimmar;
            timlön = _timLön;
        }
        public override double BeräknaLön()
        {
            return timlön * arbetadeTimmar;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
