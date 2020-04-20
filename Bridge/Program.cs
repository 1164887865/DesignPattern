using System;

namespace Bridge
{
    /// <summary>
    /// 桥接模式
    ///         Abstraction     ----聚合----    Implementor
    ///         /   |   \                       /   |   \    
    /// RefinedAbstractionA/B/C...          ConcreteImplementorA/B/C...
    /// 
    /// 两个接口，不同行为，分别实现，
    /// 在Abstraction中聚合一个Implementor，
    /// 在构造函数中给Implementor对象赋值，定义一个虚方法执行Implementor里的方法
    /// </summary>
    class Program
    {
        /// <summary>
        /// 桥接模式
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {   
            Abstraction abstraction = new RefinedAbstraction();

            abstraction.SerImplementor(new ConcreteImplementorA());
            abstraction.Operation();

            abstraction.SerImplementor(new ConcreteImplementorB());
            abstraction.Operation();

            Console.ReadKey();
        }
    }
}
