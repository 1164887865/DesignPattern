using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class SimpleFactory
    {
        public static LeiFeng CreateLeiFeng(string type)
        {
            LeiFeng res=null;

            switch (type)
            {
                case "daxuesheng":
                    res = new Undergraduate();
                    break;
                case "zhiyuanzhe":
                    res = new Volunteer();
                    break;
            }

            return res;
        }
    }
}
