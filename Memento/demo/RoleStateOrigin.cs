using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.demo
{
    class RoleStateOrigin
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public RoleStateMemento SaveState()
        {
            return new RoleStateMemento(Name, Level);
        }
        public void SetState(RoleStateMemento memento)
        {
            this.Name = memento.Name;
            this.Level = memento.Level;
        }

        public void Show()
        {
            Console.WriteLine($"{Name}({Level})");
        }

    }
}
