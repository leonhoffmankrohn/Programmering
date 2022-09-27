using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Kopplingsbräda
{
    public class Lampa
    {
        public bool StrömPå { get; set; }
        public Image DefaultColor { get; }
        public Image Color { get; set; }

        public Lampa(Image color)
        {
            StrömPå = false;
            Color = LampFärg.Släckt;
            DefaultColor = color;
        }
        
        public void TändLampa(bool on)
        {
            StrömPå = on;
            if (on)
                Color = DefaultColor;
            else
                Color = LampFärg.Släckt;
        } 

        public void SättFärg(Färg färg)
        {
            switch (färg)
            {
                case Färg.Grå:
                    Color = LampFärg.Släckt;
                    break;
                case Färg.Röd:
                    Color = LampFärg.Röd;
                    break;
                case Färg.Gul:
                    Color = LampFärg.Gul;
                    break;
                case Färg.Grön:
                    Color = LampFärg.Grön;
                    break;
            }
        }
      

    }
}
