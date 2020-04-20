using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// 指挥者类
    /// 由于产品类都是创造者抽象类的子类
    //  实例化指挥者时传入哪个产品就建造那个产品，流程在这规定好了，只提供开始建造的方法
    /// </summary>
    class DirectorClass
    {
        /// <summary>
        /// 流程写死，供上级代码直接调用
        /// </summary>
        public void StarWork(BuilderClass builder)
        {
            builder.BuildOne();
            builder.BuildTwo();
            builder.BuildThree();
        }
    }
}
