using System;

namespace Proxy
{
    class Program
    {
        /// <summary>
        /// 由代理（Proxy）向其他对象（Pursul）提供一种代理以控制对这个对象的访问
        /// 真实实体提供方法，代理对象调用真实实体的方法实现代理
        /// 接口定义了两个类的行为，使得任意要用到真实类的地方都可以使用到代理类
        /// 
        /// 应用:
        ///     远程代理，为一个对象在不同的地址空间提供局部代表  
        ///     WebService,引用WebService会生成一个WebReference，使得客户端调用代理就可以解决远程访问的问题。
        ///     
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Girl jj = new Girl();
            jj.Name = "jiaojiao";
            Proxy daili = new Proxy(jj);

            daili.GiveFlowers();
            daili.GiveChocolate();
            daili.GiveMore();
            Console.Read();
        }
    }
}
