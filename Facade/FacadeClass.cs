using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class FacadeClass
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        public FacadeClass() 
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
        }
        public void getSub()
        {
            Console.WriteLine("门面");
            one.MethodOne();
            two.MethodTwo();
            three.MethodThree();
        }
    }
}
