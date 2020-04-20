using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    /// <summary>
    /// 通知者，去通知观察者
    /// </summary>
    interface Subject
    {
        void Attach(Observer observer);
        void Detach(Observer observer);

        void Notify();

        string SubjectState { get; set; }
    }
}
