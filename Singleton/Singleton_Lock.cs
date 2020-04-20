using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// 单例 2
    /// 与单例1基本一致，多了静态只读的一个锁，用来锁定线程，
    /// 使得对象实例由最先的线程创建，其他线程等待
    /// 缺点：每次调用都会lock，影响性能
    /// </summary>
    class Singleton_Lock
    {
        //私有化本类，不能new
        private Singleton_Lock() { }
        //创建锁,适用于多线程环境中
        private static readonly object syncRoot = new object();
        //全局对象
        private static Singleton_Lock singleton = null;
        //实例化对象
        public static Singleton_Lock GetInstance()
        {
            lock (syncRoot)
            {
                if (singleton == null)
                {
                    singleton = new Singleton_Lock();
                }
            }
            return singleton;
        }
    }
}
