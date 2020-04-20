using System;

namespace Prototype
{
    /// <summary>
    /// 原型模式
    /// 把new出的对象复制一个，同时可以更改值，与【Class class = new Class();   Class1 class1=class;】不一样，
    /// 后者把class的地址告诉class1，相当于把class不变复制一份给class1
    /// 
    /// MemberwiseClone()如果字段是值类型的，则对该字段执行逐位复制，
    /// 如果字段是引用类型，则复制引用但不复制引用的对象；
    /// 因此，原始对象及其副本引用同一对象。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSome some = new ConcreteSome(1);
            ConcreteSome some1 = (ConcreteSome)some.Clone();
            Console.WriteLine(some1.Id);

            CloneSome cloneSome = new CloneSome(2);
            CloneSome cloneSome1 = (CloneSome)cloneSome.Clone();
            Console.WriteLine(cloneSome1.id);
        }
    }
}
