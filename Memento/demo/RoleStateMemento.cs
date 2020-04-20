using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.demo
{
    class RoleStateMemento
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public RoleStateMemento(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }
    }
}
