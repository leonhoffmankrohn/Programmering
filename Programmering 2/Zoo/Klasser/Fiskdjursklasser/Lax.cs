using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Lax : Fisk
    {
        public string Lekperiod { get; }
        public Lax(string _namn, double _ålder, KönTyp _kön, bool _nattaktiv, string _lekperiod) : base(_namn, _ålder, _kön, _nattaktiv)
        {
            Lekperiod = _lekperiod;
            ÄggPerKull = 10000;
        }
        public override string ToString()
        {
            return "En lax " + base.ToString() + " som har lekperioden: " + Lekperiod;
        }
    }
}
