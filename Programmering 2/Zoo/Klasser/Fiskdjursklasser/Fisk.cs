using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interfaces;

namespace Zoo
{
    abstract internal class Fisk : Djur, ILäggÄgg
    {
        Random rnd = new Random();
        // Egenskaper
        public bool Sötvatten { get; }
        public int ÄggPerKull { get; set; }

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

        public string LäggÄgg()
        {
            int a = (int)(rnd.Next(80, 120) / 100.0 * ÄggPerKull);
            return Namn + " har lagt " + a + " ägg.";
        }
    }
}
