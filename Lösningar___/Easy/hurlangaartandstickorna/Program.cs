using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hurlangaartandstickorna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Antalet stickor på golvet- (int amountSticks)
            string input = Console.ReadLine();
            int.TryParse(input, out int amountSticks);

            // Stickornas maxlängd kriterie (lengthCriteria)
            input = Console.ReadLine();
            int.TryParse(input, out int lengthCriteria);

            // Antal stickor som får plats
            input = Console.ReadLine();
            int.TryParse(input, out int placeLeftInBox);

            // Kolla längd på alla stickor och returnera om de kan eller inte kan få plats.
            for (int i = 0; i < amountSticks; i++)
            {
                input = Console.ReadLine();
                int.TryParse(input, out int stickLength);
                bool trash = CheckSpaceFor(placeLeftInBox, lengthCriteria, stickLength);
                if (!trash) placeLeftInBox--;
                Console.WriteLine((trash) ? "Papperskorgen" : "Asken");
            }
            Console.ReadKey();
        }
        static bool CheckSpaceFor(int spaceLeft, int criteria, int length)
        {
            if (spaceLeft > 0 && criteria >= length)
            {
                return false;
            }
            else return true;
        }
    }
}
