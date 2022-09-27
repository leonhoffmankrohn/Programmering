using System.Windows.Forms.VisualStyles;

namespace Kopplingsbräda
{
    public class Uppgift
    {
        public bool Uppgift1(bool knapp1, bool knapp2)
        {
            bool tänd = false;

            // Skriv din kod här:
            if (knapp1) 
            {
                tänd = true;
            }


            // Rör ej:
            return tänd;
        }

        public bool Uppgift2(bool tänt)
        {
            bool tänd = false;

            // Skriv din kod här:
            if (!tänt)
            {
                tänd = true;
            }
            

            // Rör ej:
            return tänd;
        }


        public Färg Uppgift3(int värde)
        {
            Färg färg = Färg.Grå;

            //  Skriv din kod här:
            if (värde < 4)
            {
                färg = Färg.Röd;
            }
            else if (värde > 7)
            {
                färg = Färg.Grön;
            }
            else {
                färg = Färg.Gul;
            }
            

            //  Rör ej:
            return färg;
        }


        public bool Uppgift4(bool på, int värde)
        {
            bool tänd = false;

            //  Skriv din kod här:


            if (på == true && 4 <= värde && värde <= 6)
            {
                tänd = true;
            }

            //  Rör ej:
            return tänd;
        }

        public bool Uppgift5(bool på, int värde)
        {
            bool tänd = false;

            //  Skriv din kod här:
            if (på == true && (värde < 3 || värde > 7)) tänd = true;

            //  Rör ej:
            return tänd;
        }


        public Färg Uppgift6(int pin)
        {
            Färg färg = Färg.Grå;

            //  Skriv din kod här:
            switch (pin){
                case 6342:
                    färg = Färg.Grön;
                    break;

                case 9972:
                    färg = Färg.Grön;
                    break;

                case 1336:
                    färg = Färg.Grön;
                    break;

                default:
                    färg = Färg.Röd;
                    break;
            }


            //  Rör ej:
            return färg;
        }

        public bool[] Uppgift7(bool ett, bool två, bool tre, bool fyra, bool fem, bool sex,  bool sju)
        {
            bool lampaEtt = false, lampaTvå = false, lampaTre = false;

            //  Skriv din kod här:
            if (ett && två) lampaEtt = true; 
            if ((ett && två && tre) || (fyra && tre)) lampaTvå = true;
            if (fyra && fem && sex && sju) lampaTre = true;

            //  Rör ej:
            bool[] lampor = { lampaEtt, lampaTvå, lampaTre };
            return lampor;
        }

        public Färg Uppgift8(bool på)
        {
            Färg färg = Färg.Grå;

            //  Skriv din kod här:

            färg = på ? Färg.Grön : Färg.Röd;

            // Rör ej:
            return färg;
        }

    }
}
