using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract internal class Däggdjur : Djur
    {
        // Egenskap
        public bool Nattaktiv { get; }

        // Konstruktören
        public Däggdjur(string _namn, double _ålder, KönTyp _kön, bool _nattaktiv) : base(_namn, _ålder, _kön)
        {
            Nattaktiv = _nattaktiv;
        }

        // Skriver ut motsvarnde värde för egenskapen Nattaktiv
        public override string ToString()
        {
            return (Nattaktiv) ? "Ett däggdjur som är nattaktiv" : "Ett däggdjur som ej är nattaktiv";
        }
    }
}
