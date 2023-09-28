using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Fisk : Djur
    {
        public bool Sötvatten { get; }

        Fisk(string _namn, double _ålder, KönTyp _kön) : base(_namn, _ålder, _kön)
        {

        }
        public override string ToString()
        {
            return "En fisk som lever i sötvatten";
        }
    }
}
