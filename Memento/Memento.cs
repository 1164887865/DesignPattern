using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Memento
    {
        public readonly string State;
        public Memento(string State)
        {
            this.State = State;
        }
    }
}
