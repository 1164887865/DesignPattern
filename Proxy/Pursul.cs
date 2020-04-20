using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    //行为者
    class Pursul : Gift
    {
        Girl Girl;
        public Pursul(Girl girl) 
        {
            this.Girl = girl;
        }
        public void GiveChocolate()
        {
            Console.WriteLine(Girl.Name+ "GiveChocolate");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(Girl.Name + "GiveFlowers");
        }

        public void GiveMore()
        {
            Console.WriteLine(Girl.Name + "GiveMore");

        }
    }
}
