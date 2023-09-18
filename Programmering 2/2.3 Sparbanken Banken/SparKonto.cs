using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Sparbanken_Banken
{
    internal class SparKonto : BankKonto
    {
        public SparKonto(string _personNummer, double _behållning, double _räntesats) : base(_personNummer, _behållning, _räntesats) { }
        public override bool Uttag(double belopp)
        {
            if (behållning - belopp < 0)
                return false;
            else behållning -= belopp;
            return true;
        }
        public override double BeräknaRänta()
        {
            behållning *= räntesats+1;
            return behållning * räntesats;
        }

        public override string ToString()
        {
            return "Sparkonto: " + personNummer + " Behållning: " + behållning + " kr";
        }
    }
}
