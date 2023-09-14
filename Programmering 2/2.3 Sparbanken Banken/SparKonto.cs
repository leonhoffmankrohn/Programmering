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
