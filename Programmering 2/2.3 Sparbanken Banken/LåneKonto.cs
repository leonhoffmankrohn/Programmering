using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Sparbanken_Banken
{
    internal class LåneKonto : BankKonto
    {
        double kreditGräns;

        public LåneKonto(string _personNummer, double _behållning, double _räntesats, double _kreditGräns) : base(_personNummer, _behållning, _räntesats)
        {
            kreditGräns = _kreditGräns;
        }
        public override bool Uttag(double belopp)
        {
            if (behållning-belopp < kreditGräns * -1)
            {
                return false;
            }
            else
            {
                behållning -= belopp;
                return true;
            }
        }
        public override double BeräknaRänta()
        {
            behållning -= behållning * räntesats;
            return behållning - behållning * räntesats;
        }

        public override string ToString()
        {
            return "Lånekonto: " + personNummer + " Behållning: " + behållning + " kr";
        }
    }
}
