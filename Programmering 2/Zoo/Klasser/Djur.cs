using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Djur
    {
        // Egenskaperna
        public int Id { get; set; }
        public string Namn { get; }
        public double Ålder { get; }
        public KönTyp Kön { get; }
        public string Beskrivning { get { return ToString(); } }

        // Här kommer konstruktören för att skapa ett djur och här ökar den även "id"
        public Djur(string _namn, double _ålder, KönTyp _kön)
        {
            Namn = _namn;
            Ålder = _ålder;
            Kön = _kön;
        }

        // Tostring returnerar objektets tostring
        public abstract override string ToString();
    }
}
