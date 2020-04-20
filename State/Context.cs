using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Context
    {
        private State State;
        public State state { get { return State; } set { State = value; Console.WriteLine("当前状态："+ State.GetType().Name); } }

        public Context(State _state)
        {
            this.state = _state;
        }

        public void Request()
        {
            state.Handle(this);
        }
    }
}
