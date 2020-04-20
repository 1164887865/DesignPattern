using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //简单工厂使用
            LeiFeng s1 = SimpleFactory.CreateLeiFeng("daxuesheng");
            s1.BySomething();
            LeiFeng s2 = SimpleFactory.CreateLeiFeng("zhiyuanzhe");
            s2.Sweep();

            //工厂模式
            //克服了简单工厂的缺点：每次新增功能都要去修改工厂（开放-封闭原则）
            //保留了简单工厂的优点：保持封装对象的创建过程的优点
            //缺点：每增加一个产品，就需要加一个产品工厂类，增加额外开发量。


            IFactory factory = new UndergraduateFactory();
            LeiFeng undergradute = factory.CreateLeiFeng();
            undergradute.BySomething();
            undergradute.Sweep();
            undergradute.Wash();



            Console.ReadKey(); 
        }
    }
}
