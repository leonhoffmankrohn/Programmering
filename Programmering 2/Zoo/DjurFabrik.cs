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

        public void SkapaDjur(Enum arttyp, string namn, double ålder, KönTyp kön, bool harExtraAttribut, string attribut2)
        {
            if (arttyp is DäggdjurTyp)
            {

            }
            else if (arttyp is FiskTyp)
            {

            }
        }
    }
}
