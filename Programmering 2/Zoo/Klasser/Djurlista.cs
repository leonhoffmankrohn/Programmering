using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ListManager;

namespace Zoo
{
    internal class Djurlista<Djur> : ListManager<Djur>
    {
        static int id = 0;
        public override bool Add(Djur djuret)
        {
            djuret.ID = ++id;
        }
    }
}
