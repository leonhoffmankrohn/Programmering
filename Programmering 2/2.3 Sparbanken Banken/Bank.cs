using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Sparbanken_Banken
{
    internal class Bank
    {
        public List<BankKonto> konton = new();

        public double Behållning 
        {
            get
            { 
                double bankBehållning = 0;
                foreach (BankKonto konto in konton) bankBehållning += konto.Behållning;
                return bankBehållning;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
