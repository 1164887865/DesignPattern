using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class LeiFeng
    {
        public void BySomething()
        {
            Console.WriteLine("BySomething");
        }
        public void Wash()
        {
            Console.WriteLine("Wash");
        }
        public void Sweep()
        {
            Console.WriteLine("Sweep");
        }
    }
    class Undergraduate : LeiFeng
    {
        
    }

    class Volunteer : LeiFeng
    {

    }

}
