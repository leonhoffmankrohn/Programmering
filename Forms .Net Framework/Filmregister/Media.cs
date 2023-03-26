using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmregister
{
    class Media
    {
        string namn;
        string genre;

        public string Namn { get { return namn; } set { namn = value; } }
        public string Genre { get { return genre; } set { genre = value; } }
        public int Antal { get { return 0; } }
        public string Typ { get { return ""; } }

        public Media (string _namn, string _genre)
        {
            namn = _namn;
            genre = _genre;
        }

        public override string ToString()
        {
            return "Namn: " + namn + " Genre: " + genre + " ";
        }
    }
    class Film : Media
    {
        int speltid;
        string filmtyp;

        virtual public int Antal{ get { return speltid; } set { speltid = value; } }
        virtual public string Typ { get { return filmtyp; } set { filmtyp = value; } }

        public Film(string _namn, string _genre, int _speltid, string _filmtyp) : base(_namn, _genre)
        {
            speltid = _speltid;
            filmtyp = _filmtyp;
        }

        public override string ToString()
        {
            return base.ToString() + "Speltid: " + speltid + " Filmtyp: " + filmtyp;
        }

    }
    class Serie : Media
    {
        int säsonger;
        string serietyp;

        override public int Antal { get { return säsonger; } set { säsonger = value; } }
        override public string Typ { get { return serietyp; } set { serietyp = value; } }

        public Serie(string _namn, string _genre, int _säsonger, string _serietyp) : base(_namn, _genre)
        {
            säsonger = _säsonger;
            serietyp = _serietyp;
        }

        public override string ToString()
        {
            return base.ToString() + "Säsonger: " + säsonger + " Serietyp: " + serietyp;
        }
    }
}
