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
        public bool Uttag(double belopp)
        {
            return true;
        }
        public double BeräknaRänta()
        {
            return 0;
        }
    }
}
