using System;

namespace Decorator
{
    class Program
    {
        /// <summary>
        /// 装饰器模式：
        ///     为了更好向已有的功能动态的添加一些功能。
        ///     当新加入的东西仅仅是为了满足一些只在某种特定情况下才会执行的特殊行为，装饰器模式提供了非常好的解决方案。
        ///     当需要执行特殊行为时，可以选择地、有序地使用装饰功能装饰对象。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Person person = new Person("zz");
            TShirts shirts = new TShirts();
            BigTrouser bigTrouser = new BigTrouser();

            shirts.Decorate(person);
            bigTrouser.Decorate(shirts);

            bigTrouser.Show();
            Console.ReadLine();
        }
    }
}
