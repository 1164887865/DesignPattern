using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// 单例 3
    /// 与单例2基本一致，再增加一个判断实例是否存在，不存在再加锁处理
    /// 这种做法成为Double-Check Locking（双重锁定）双if加lock
    /// </summary>
    class Singleton_IfLock
    {
        //私有化本类，不能new
        private Singleton_IfLock() { }
        //创建锁,适用于多线程环境中
        private static readonly object syncRoot = new object();
        //全局对象
        private static Singleton_IfLock singleton = null;
        //实例化对象
        public static Singleton_IfLock GetInstance()
        {
            //对象为空才进入锁，否则直接返回，使得不会线程一直在lock处阻塞
            //第一个线程进入lock后实例化对象，后面的线程中singleton!=null，直接返回
            if (singleton == null)
            {
                lock (syncRoot)
                {
                    if (singleton == null)
                    {
                        singleton = new Singleton_IfLock();
                    }
                }
            }
            return singleton;
        }
    }
}
