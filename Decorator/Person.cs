using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    /// <summary>
    /// 作为 ConcreteComponent
    /// </summary>
    class Person
    {
        public Person() { }

        private string name;

        public Person(string _name) 
        {
            name = _name;
        }

        public virtual void Show()
        {
            Console.WriteLine(name);
        }

    }
}
