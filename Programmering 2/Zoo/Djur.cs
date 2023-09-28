using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Djur
    {
        // Denna kommer att öka för varje skapat djur
        static int id = 0;

        // Egenskaperna
        public int Id { get; }
        public string Namn { get; }
        public double Ålder { get; }
        public KönTyp Kön { get; }
        public string Beskrivning { get { return ToString(); } }

        // Här kommer konstruktören för att skapa ett djur och här ökar den även "id"
        public Djur(string _namn, double _ålder, KönTyp _kön)
        {
            Id = ++id;
            Namn = _namn;
            Ålder = _ålder;
            Kön = _kön;
        }

        // Tostring returnerar objektets tostring
        public abstract override string ToString();
    }
}
