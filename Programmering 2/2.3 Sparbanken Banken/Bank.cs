using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Sparbanken_Banken
{
    internal class Bank
    {
        public BankKonto[] konton;

        public double Behållning { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
