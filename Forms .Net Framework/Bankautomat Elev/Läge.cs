using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankautomat
{
    public enum Läge
    {
        Insättning,
        Uttag,
        Inloggning,
        Historik
    }

    public enum Metod
    {
        Enstaka,
        Rensa,
        HistorikCount,
        TaBortAlla,
        Historik,
        Saldo,
        Avbryt

    }
}
