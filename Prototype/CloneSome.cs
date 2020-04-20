using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// ICloneable接口只有一个方法Clone
    /// 实现Clone方法即可
    /// </summary>
    class CloneSome :ICloneable
    {
        private int ID;
        public int id
        {
            get { return ID; }
        }

        public CloneSome(int id)
        {
            this.ID = id;
        }
        public Object Clone() 
        {
            return (Object)this.MemberwiseClone();
        }
    }
}
