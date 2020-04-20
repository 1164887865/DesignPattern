using System;
using System.Collections.Generic;
using System.Text;

namespace Template
{
    class ConcreteClassA : AbstractClass
    {
        //特定实现  可以有多个
        public override string ReturnAnswer1()
        {
            return "a";
        }

        public override string ReturnAnswer2()
        {
            return "b";
        }
    }
}
