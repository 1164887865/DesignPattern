using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    /// <summary>
    /// 观察者下一个子类观察者
    /// </summary>
    class NBAObserver : Observer
    {
        public NBAObserver(string name,Subject subject):base(name,subject)
        {
            
        }
        public override void Update()
        {
            Console.WriteLine("通知" + name+subject.SubjectState);
        }
    }
}
