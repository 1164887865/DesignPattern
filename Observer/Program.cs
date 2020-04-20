using System;

namespace Observer
{
    class Program
    {
        /// <summary>
        ///     观察者模式有叫发布-订阅模式（Publish/Subscribe）
        /// 应用：当一个对象的改变需要同时改变其他对象时，且它不知道要改变多少对象，
        ///     解除耦合，让耦合的双方都依赖于抽象，而不是依赖具体，从而使得一方的变化不会影响另外一方。
        /// 观察者模式定义了一种一对多的依赖关系，让多个观察者对象同时监听某一个主体对象，
        /// 这个主题对象在发生改变的时候会通知所有观察者对象，使他们自动更新自己。
        /// 
        /// 通知者把所有的观察者对象的引用保存在一个集合中（Subect），可以有任意数量的观察者（Observer），
        /// 抽象主题提供接口，可以添加和删除观察者对象
        /// 
        /// 抽象观察者为所有具体观察者提供一个接口，在得到通知者的通知时更新自己。
        /// 
        /// 具体通知者将状态存入具体观察者对象，在具体观察者改变时，调用集合中所有观察者的更新方法发出通知。
        /// 
        /// 具体观察者实现抽象观察者的更新接口以协调自身状态。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            BossSubject boss = new BossSubject();
            boss.Attach(new NBAObserver("nbasub", boss));
            boss.SubjectState = "boss comback";
            boss.Notify();

        }
    }
}
