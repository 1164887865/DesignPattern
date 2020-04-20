using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// 具体构造者
    /// 产品部件类2，实现规定的工艺
    /// </summary>
    class ProductTwo : BuilderClass
    {
        Product product = new Product();

        public override void BuildOne()
        {
            product.Add("产品2部件1");

        }
        public override void BuildTwo()
        {
            product.Add("产品2部件2");

        }
        public override void BuildThree()
        {
            product.Add("产品2部件3");

        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
