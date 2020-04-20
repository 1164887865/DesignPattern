using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class ConcreteStateA:State
    {
        public override void Handle(Context context)
        {
            
            context.state = new ConcreteStateB();
        }
    }
}
