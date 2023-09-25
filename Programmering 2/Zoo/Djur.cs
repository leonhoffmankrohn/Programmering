using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Djur
    {
        enum Kön
        {
            Hona,
            Hane
        }
        double ID;
        string namn;
        double ålder;
        Kön kön;
        static double id = 0;

        Djur(string _namn, double _ålder, Enum _kön)
        {
            ID = ++id;
            namn = _namn;
            ålder = _ålder;
            kön = _kön;
        }

    }
}
