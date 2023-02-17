using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmregister
{
    internal class Film
    {
        /*
            Filmregistret ska ta in film och dens namn i konstruktör.
            Man ska kunna visa årgång, skådespelare, genre, regissör och revenue.
        */
        List<string> skådespelare = new List<string>();
        string genre;
        string regissör;
        int profit;

        public int Årgång { get; }

        public string Genre 
        {
            get 
            {
                return genre;
            }
            set 
            {
                genre = value;
            }
        }
        public string Regissör { }
    }
}
