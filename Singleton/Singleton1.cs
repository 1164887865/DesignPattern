using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// 单例 1 - 懒汉模式
    /// 私有化本类，使外界不能new，定义一个static方法判断本类对象是否为空后创建对象
    /// 缺点：多线程时还是会创建多个对象
    /// </summary>
    class Singleton
    {
        //私有化本类，不能new
        private Singleton() { }
        //全局对象
        private static Singleton singleton = null;
        //实例化对象
        public static Singleton GetInstance()
        {
            if (singleton == null)
            {
                //只在自己第一次被【引用】时才将自己实例化，成为懒汉模式
                singleton = new Singleton();
            }
            return singleton;
        }
    }
}
