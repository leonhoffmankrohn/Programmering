using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Personalregister
{
    internal class Kontorist : Anställd
    {
        double månadsLön;

        public Kontorist(string _namn, double _månadsLön) : base(_namn)
        {
            månadsLön = _månadsLön;
        }


        public override double BeräknaLön()
        {
            return månadsLön;
        }

        public override string ToString()
        {
            return "Typ: Kontorist ; Månadslön: " + månadsLön + " kr ;;; Lön: " + BeräknaLön() + " kr";
        }
    }
}
