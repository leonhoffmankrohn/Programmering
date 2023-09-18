using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Sparbanken_Banken
{
    abstract class BankKonto
    {
        protected string personNummer;
        protected double behållning;
        protected double räntesats;

        public double Behållning
        {
            get { return behållning; } set { behållning = value;}
        }

        public BankKonto(string _personNummer, double _behållning, double _räntesats)
        {
            personNummer = _personNummer;
            behållning = _behållning;
            räntesats = _räntesats;
        }


        public abstract bool Uttag(double belopp);
        public abstract double BeräknaRänta();

        public void Insättning(double belopp)
        {
            behållning += belopp;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
