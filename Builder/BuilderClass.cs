using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// 创造者抽象类，用于制定子类相同工艺
    /// </summary>
    abstract class BuilderClass
    {
        public abstract void BuildOne();
        public abstract void BuildTwo();
        public abstract void BuildThree();
        public abstract Product GetResult();
    }
}
