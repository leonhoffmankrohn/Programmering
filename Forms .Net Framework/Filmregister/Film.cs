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
        // Skådespelare, årgång, regissör, vinst
        int årgång;
        string regissör = "";

        public int Årgång 
        { 
            get 
            {
                return årgång;
            }
        
        }
        public string Genre { get; set; }
        public string Regissör 
        {
            get 
            {
                return regissör;
            } 
        }
        public int Vinst { get; set; }



        public Film(int _årgång = 0, string _regissör = "okänd", int _vinst = 0, List<string> _skådespelare)
        {
            skådespelare = (_skådespelare == null) ? _skådespelare : skådespelare;
            Vinst = _vinst;
            årgång = _årgång;
            regissör = _regissör;
        }
    }
}
