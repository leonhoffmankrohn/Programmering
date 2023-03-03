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
        List<string> skådespelare = new List<string> {""};
        // Skådespelare, årgång, regissör, vinst, namn

        public string Namn { get; }
        public int Årgång { get; }
        public string Regissör { get; }
        public string Genre { get; set; }
        public int Vinst { get; set; }



        public Film(string _namn, int _årgång = 0, string _regissör = "okänd", string _genre = "okänd", int _vinst = 0)
        {
            Namn = _namn;
            Årgång = _årgång;
            Regissör = _regissör;
            Genre = _genre;
            Vinst = _vinst;
        }

        public string Hämtasträng()
        { 
            
        }
    }
}
