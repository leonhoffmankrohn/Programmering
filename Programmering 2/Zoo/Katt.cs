using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Katt : Däggdjur
    {
        public string Päls { get; }
        public Katt(string _namn, double _ålder, KönTyp _kön, bool _nattaktiv, string _päls) : base(_namn, _ålder, _kön, _nattaktiv)
        {
            Päls = _päls;
        }
        public override string ToString()
        {
            return base.ToString() + " och har " + Päls + " päls";
        }
    }
}
