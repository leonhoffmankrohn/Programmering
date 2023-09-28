using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Däggdjur : Djur
    {
        public bool Nattaktiv { get; }

        Däggdjur(string _namn, double _ålder, KönTyp _kön) : base(_namn, _ålder, _kön)
        {

        }
        public override string ToString()
        {
            return "Ett däggdjur som är nattaktiv";
        }
    }
}
