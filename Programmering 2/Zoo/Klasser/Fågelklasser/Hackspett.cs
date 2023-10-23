using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Klasser.Fågelklasser
{
    internal class Hackspett : Fågel
    {
        public string Typ { get; }
        public Hackspett(string _namn, double _ålder, KönTyp _kön, bool _flyttfågel, string _typ) : base(_namn, _ålder, _kön, _flyttfågel)
        {
            Typ = _typ;
            ÄggPerKull = 6;
        }
        public override string ToString()
        {
            return "En hackspett " + base.ToString() + " som har typen: " + Typ;
        }
    }
}
