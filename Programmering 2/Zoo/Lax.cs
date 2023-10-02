using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Lax : Fisk
    {
        public string Födelseplats { get; }
        public Lax(string _namn, double _ålder, KönTyp _kön, bool _nattaktiv, string _födelseplats) : base(_namn, _ålder, _kön, _nattaktiv)
        {
            Födelseplats = _födelseplats;
        }
        public override string ToString()
        {
            return base.ToString() + " och är född i " + Födelseplats;
        }
    }
}
