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
        double timLön;

        public Konsult(string _namn, double _arbetadeTimmar, double _timLön) : base(_namn)
        {
            arbetadeTimmar = _arbetadeTimmar;
            timLön = _timLön;
        }
        public override double BeräknaLön()
        {
            return timLön * arbetadeTimmar;
        }

        public override string ToString()
        {
            return "Typ: Konsult ; Arbetade timmar: " + arbetadeTimmar + " h ; Timlön: " + timLön + " kr ;;; Lön: " + BeräknaLön() + " kr";
        }
    }
}
