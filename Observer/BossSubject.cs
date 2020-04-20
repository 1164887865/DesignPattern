using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class BossSubject : Subject
    {
        private IList<Observer> observers = new List<Observer>();
        public string SubjectState { get ; set; }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }
        /// <summary>
        /// 通知
        /// </summary>
        public void Notify()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }
    }
}
