using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Sill : Fisk
    {
        public string Lekperiod { get; }
        public Sill(string _namn, double _ålder, KönTyp _kön, bool _nattaktiv, string _lekperiod) : base(_namn, _ålder, _kön, _nattaktiv)
        {
            Lekperiod = _lekperiod;
        }
        public override string ToString()
        {
            return "En sill " + base.ToString() + " som har lekperioden: " + Lekperiod;
        }
    }
}
