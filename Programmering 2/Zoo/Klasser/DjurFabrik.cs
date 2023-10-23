using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class DjurFabrik
    {
        public DjurFabrik() { }

        // Metod som skickar tillbaka ett objekt av rätt typ och som är fylld med rätt data
        public Djur SkapaDjur(Enum djurtyp, Enum arttyp, string namn, double ålder, KönTyp kön, bool harExtraAttribut, string attribut2)
        {
            if (djurtyp.Equals(DjurTyp.Däggdjur)) // Grupp däggdjur
            {
                if (arttyp.Equals(DäggdjurTyp.Hund)) return (new Hund(namn, ålder, kön, harExtraAttribut, attribut2));
                else return (new Katt(namn, ålder, kön, harExtraAttribut, attribut2));
            }
            else // Grupp fisk
            {
                if (arttyp.Equals(FiskTyp.Lax)) return (new Lax(namn, ålder, kön, harExtraAttribut, attribut2));
                else return (new Sill(namn, ålder, kön, harExtraAttribut, attribut2));
            }
        }
    }
}
