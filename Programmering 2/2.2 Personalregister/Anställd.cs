using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Personalregister
{
    internal class Anställd
    {
        string namn;

        public Anställd(string _namn)
        {
            namn = _namn;
        }

        public virtual double BeräknaLön()
        {
            return 0;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
