using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.WriteLine("BigTrouser");

            base.Show();
        }
    }
}
