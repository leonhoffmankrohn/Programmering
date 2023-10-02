using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Hund : Däggdjur
    {
        public string Ras { get; }
        public Hund(string _namn, double _ålder, KönTyp _kön, bool _nattaktiv, string _ras) : base(_namn, _ålder, _kön, _nattaktiv)
        {
            Ras = _ras;
        }
        public override string ToString()
        {
            return base.ToString() + " och är av rasen " + Ras;
        }
    }
}
