using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class Finery : Person
    {
        protected Person component;

        public void Decorate(Person person) 
        {
            component = person;
        }
        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }
        }
    }
}
