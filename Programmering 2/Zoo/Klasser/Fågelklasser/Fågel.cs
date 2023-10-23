using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interfaces;

namespace Zoo.Klasser.Fågelklasser
{
    internal class Fågel : Djur, ILäggÄgg
    {
        Random rnd = new Random();
        // Egenskaper
        public bool Flyttfågel { get; }
        public int ÄggPerKull { get; set; }

        // Konstruktören
        public Fågel(string _namn, double _ålder, KönTyp _kön, bool _flyttfågel) : base(_namn, _ålder, _kön)
        {
            Flyttfågel = _flyttfågel;
        }

        // Returnerar ett värde motsvarande till egenskapen
        public override string ToString()
        {
            return (Flyttfågel) ? "som är en flyttfågel" : "som inte är en flyttfågel";
        }

        public string LäggÄgg()
        {
            int a = (int)(rnd.Next(80, 120) / 100 * ÄggPerKull);
            return Namn + "har lagt " + a + " ägg.";
        }
    }
}
