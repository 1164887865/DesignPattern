using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    /// <summary>
    /// 发起人
    /// </summary>
    class Originator
    {
        //public Member member { get; set; }
        public string State { get; set; }

        public Memento CreateMemento()
        {
            return new Memento(State);
        }

        public void SetMemento(Memento memento)
        {
            this.State = memento.State;
        }
        public void Show()
        {
            Console.WriteLine($"Member:{this.State}");
        }
    }
}
