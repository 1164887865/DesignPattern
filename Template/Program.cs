using System;

namespace Template
{
    class Program
    {
        /// <summary>
        ///     模板方法模式
        /// 定义一个操作中的算法骨架，而将一些步骤延迟到子类中。
        /// 模板方法使得子类不改变一个算法的结构即可重定义该算法的某些特定步骤
        /// 简单地说，就是把不变的行为放在超类，去除子类的重复代码。
        /// 
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            AbstractClass ab;
            ab = new ConcreteClassA();
            ab.Template();
        }
    }
}
