using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract internal class Fisk : Djur
    {
        // Egenskaper
        public bool Sötvatten { get; }

        // Konstruktören
        public Fisk(string _namn, double _ålder, KönTyp _kön, bool _sötvatten) : base(_namn, _ålder, _kön)
        {
            Sötvatten = _sötvatten;
        }

        // Returnerar ett värde motsvarande till egenskapen
        public override string ToString()
        {
            return (Sötvatten) ? "som lever i sötvatten" : "som lever i havet";
        }
    }
}
