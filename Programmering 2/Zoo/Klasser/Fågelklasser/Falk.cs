using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Klasser.Fågelklasser
{
    internal class Falk : Fågel
    {
        public int Vingspann { get; }
        public Falk(string _namn, double _ålder, KönTyp _kön, bool _flyttfågel, string _vingspann) : base(_namn, _ålder, _kön, _flyttfågel)
        {
            int.TryParse(_vingspann, out int v);
            Vingspann = v;
            ÄggPerKull = 4;
        }
        public override string ToString()
        {
            return "En falk " + base.ToString() + " som har vingspannet: " + Vingspann + " meter";
        }
    }
}
