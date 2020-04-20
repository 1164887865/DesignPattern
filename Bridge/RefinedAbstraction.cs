using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    /// <summary>
    /// Abstraction实现方法
    /// </summary>
    class RefinedAbstraction :Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
