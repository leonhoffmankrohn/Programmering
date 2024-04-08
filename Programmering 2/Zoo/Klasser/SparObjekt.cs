using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Klasser
{
    class SparObjekt
    {
        public int ID { get; set; }
        public List<Djur> Djurlista { get; set; }

        public SparObjekt(int _id, List<Djur> _djurlista)
        {
            ID = _id;
            Djurlista = _djurlista;
        }
    }
}
