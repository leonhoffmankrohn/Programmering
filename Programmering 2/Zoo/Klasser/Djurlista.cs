using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ListManager;
using Zoo.Klasser;

namespace Zoo
{
    internal class Djurlista : ListManager<Djur>
    {
        static int id = 0;

        public SparObjekt SparaLista()
        {
            return new SparObjekt(id, lista);
        }

        public void Hämtalista(SparObjekt hämtadlista)
        {
            id = hämtadlista.ID;
            lista = hämtadlista.Djurlista;
        }

        /// <summary>
        /// Lägger till ett <djur> djuret i listan
        /// </summary>
        /// <param name="djuret"></param>
        /// <returns></returns>
        public override bool Add(Djur djuret)
        {
            djuret.Id = ++id;
            return base.Add(djuret);
        }

        /// <summary>
        /// Hämtar kopia av djurlista
        /// </summary>
        /// <returns>List<djur> lista</returns>
        public List<Djur> HämtaKopia()
        {
            return lista;
        }

        /// <summary>
        /// Hämtar index av ett Djur djuret i djurlistan
        /// </summary>
        /// <param name="djuret"></param>
        /// <returns>index</returns>
        public int IndexOfDjur(Djur djuret)
        {
            return lista.IndexOf(djuret);
        }
        
    }
}
