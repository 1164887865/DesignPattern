using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class Proxy : Gift
    {
        Pursul gg;
        public Proxy(Girl mm) 
        {
            gg = new Pursul(mm);
        }

        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }

        public void GiveMore()
        {
            gg.GiveMore();
        }
    }
}
