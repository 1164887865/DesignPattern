using System;

namespace Builder
{
    class Program
    {
        /// <summary>
        /// 建造者模式
        /// 
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            DirectorClass director = new DirectorClass();
            //开始建造产品1
            BuilderClass one = new ProductOne();
            director.StarWork(one);//建造完毕
            Product p1 = one.GetResult();//获得结果
            p1.Show();

            //开始建造产品2
            BuilderClass two = new ProductTwo();
            director.StarWork(two);
            Product p2 = two.GetResult();
            p2.Show();

        }
    }
}
