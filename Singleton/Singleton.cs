using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// 单例 1 - 饿汉模式
    /// 私有化本类，使外界不能new，定义一个static方法判断本类对象是否为空后创建对象
    /// 缺点：多线程时还是会创建多个对象
    /// </summary>
    public sealed class Singleton1
    {
        //私有化本类，不能new
        private Singleton1() { }
        //readonly值能在静态初始化期间或构造函数中分配变量，由于这种静态初始化在自己被【加载】时就将自己实例化，所以被成为饿汉模式
        private static readonly Singleton1 singleton = new Singleton1();
        //实例化对象
        public static Singleton1 GetInstance()
        {
            return singleton;
        }
    }
}
