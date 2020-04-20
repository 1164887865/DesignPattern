using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    abstract class Some
    {
        private int ID;

        public int Id 
        {
            get { return ID; }
        }
        public Some(int id)
        {
            this.ID = id;
        }

        public abstract Some Clone();
    }
}
