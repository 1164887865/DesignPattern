using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    /// <summary>
    /// 观察者
    /// </summary>
    abstract class Observer
    {
        protected string name;
        protected Subject subject;
        public Observer(string _name,Subject _subject )
        {
            this.name = _name;
            this.subject = _subject;
        }
        public abstract void Update();
    }
}
