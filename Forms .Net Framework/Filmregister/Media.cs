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

        public Media (TextBox _namnBox, ComboBox _genreBox)
        {
            namnBox = _namnBox;
            genreBox = _genreBox;
            namn = namnBox.Text;
            genre = genreBox.Text;
        }
        // Ställer text och combobox till data kopplad till objektet
        public virtual void Hämta()
        {
            namnBox.Text = namn;
            genreBox.Text = genre;
        }

        // Returnerar en utsträng
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

        public Film(TextBox _namnBox, ComboBox _genreBox, TextBox _speltidBox, ComboBox _filmtypBox) : base(_namnBox, _genreBox)
        {
            speltidBox = _speltidBox;
            filmtypBox = _filmtypBox;
            speltid = int.Parse(speltidBox.Text);
            filmtyp = filmtypBox.Text;
        }

        // Ställer boxar till objektdatat
        public override void Hämta()
        {
            base.Hämta();
            speltidBox.Text = speltid.ToString();
            filmtypBox.Text = filmtyp;
        }
        // Returnerar en sträng som motsvarar objektet
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

        public Serie(TextBox _namnBox, ComboBox _genreBox, TextBox _säsongerBox, ComboBox _serietypBox) : base(_namnBox, _genreBox)
        {
            säsongerBox = _säsongerBox;
            serietypBox = _serietypBox;
            säsonger = int.Parse(säsongerBox.Text);
            serietyp = serietypBox.Text;
        }

        // Ställer boxar till objektdatat
        public override void Hämta()
        {
            base.Hämta();
            säsongerBox.Text = säsonger.ToString();
            serietypBox.Text = serietyp;
        }

        // Returnerar en sträng som motsvarar objektet
        public override string ToString()
        {
            return "SERIE: " + base.ToString() + "Säsonger: " + säsonger + " Serietyp: " + serietyp;
        }
    }
}
