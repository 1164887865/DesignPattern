using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class ConcreteSome : Some
    {
        public ConcreteSome(int id) : base(id) 
        {

        }
        public override Some Clone()
        {
            return (Some)this.MemberwiseClone();
        }
    }
}
