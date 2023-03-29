using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Filmregister
{
    class Media
    {
        TextBox namnBox;
        ComboBox genreBox;
        string namn;
        string genre;

        public string Namn { get { return namn; } set { namn = value; } }
        public string Genre { get { return genre; } set { genre = value; } }

        public Media (TextBox _namnBox, ComboBox _genreBox)
        {
            namnBox = _namnBox;
            genreBox = _genreBox;
            namn = namnBox.Text;
            genre = genreBox.Text;
        }
        public virtual void Hämta()
        {
            namnBox.Text = namn;
            genreBox.Text = genre;
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
        TextBox speltidBox;
        ComboBox filmtypBox;

        public int Speltid{ get { return speltid; } set { speltid = value; } }
        public string Filmtyp { get { return filmtyp; } set { filmtyp = value; } }

        public Film(TextBox _namnBox, ComboBox _genreBox, TextBox _speltidBox, ComboBox _filmtypBox) : base(_namnBox, _genreBox)
        {
            speltidBox = _speltidBox;
            filmtypBox = _filmtypBox;
            speltid = int.Parse(speltidBox.Text);
            filmtyp = filmtypBox.Text;
        }
        public override void Hämta()
        {
            base.Hämta();
            speltidBox.Text = speltid.ToString();
            filmtypBox.Text = filmtyp;
        }
        public override string ToString()
        {
            return "FILM: " + base.ToString() + "Speltid: " + speltid + " Filmtyp: " + filmtyp;
        }

    }
    class Serie : Media
    {
        int säsonger;
        string serietyp;
        TextBox säsongerBox;
        ComboBox serietypBox;

        public int Säsonger { get { return säsonger; } set { säsonger = value; } }
        public string Serietyp { get { return serietyp; } set { serietyp = value; } }

        public Serie(TextBox _namnBox, ComboBox _genreBox, TextBox _säsongerBox, ComboBox _serietypBox) : base(_namnBox, _genreBox)
        {
            säsongerBox = _säsongerBox;
            serietypBox = _serietypBox;
            säsonger = int.Parse(säsongerBox.Text);
            serietyp = serietypBox.Text;
        }
        public override void Hämta()
        {
            base.Hämta();
            säsongerBox.Text = säsonger.ToString();
            serietypBox.Text = serietyp;
        }
        public override string ToString()
        {
            return "SERIE: " + base.ToString() + "Säsonger: " + säsonger + " Serietyp: " + serietyp;
        }
    }
}
