using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现B的方法");
        }
    }
}
