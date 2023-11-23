using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Uppgift_4___Klippa_protein
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string orentProtein = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out int begränsning);


            List<int> klippningar = new List<int>();
            List<bool> bools = new List<bool>(orentProtein.Length);

            // Tills alla möjliga kombinationer är uppnådda
            //      gör en binär räkning, där vi räknar alla gånger vi klippt, om de är lika med varandra
            

        }
    }
}
