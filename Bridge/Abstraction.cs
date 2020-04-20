using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Abstraction
    {
        protected Implementor implementor;

        public void SerImplementor(Implementor implementor)
        {
            this.implementor = implementor;
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}
