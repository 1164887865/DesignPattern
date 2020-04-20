using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.state = new ConcreteStateA();
        }
    }
}
