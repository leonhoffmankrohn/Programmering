using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Kopplingsbräda
{
    public class Lampor
    {
        List<Lampa> lampor = new List<Lampa>();

        public Lampor()
        {
            GenereraLampor();    
        }

        public List<Lampa> HämtaLampor()
        {
            return lampor;
        }

        public Lampa HämtaLampa(int i)
        {
            return lampor[i];
        }

        public void GenereraLampor()
        {
            lampor.Add(new Lampa(LampFärg.Gul));    // uppg1
            lampor.Add(new Lampa(LampFärg.Gul));    // uppg2
            lampor.Add(new Lampa(LampFärg.Röd));    // uppg3
            lampor.Add(new Lampa(LampFärg.Röd));    // Power_4
            lampor.Add(new Lampa(LampFärg.Grön));   // uppg4
            lampor.Add(new Lampa(LampFärg.Röd));    // Power_5
            lampor.Add(new Lampa(LampFärg.Grön));   // uppg5
            lampor.Add(new Lampa(LampFärg.Röd));    // uppg6
            //  uppg7:
            lampor.Add(new Lampa(LampFärg.Grön));
            lampor.Add(new Lampa(LampFärg.Grön));
            lampor.Add(new Lampa(LampFärg.Grön));

            lampor.Add(new Lampa(LampFärg.Röd));   // uppg7

        }
    }
}
