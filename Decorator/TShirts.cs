using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class TShirts : Finery
    {
        public override void Show()
        {
            Console.WriteLine("TShirts");

            base.Show();
        }

    }
}
