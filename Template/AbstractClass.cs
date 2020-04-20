using System;
using System.Collections.Generic;
using System.Text;

namespace Template
{
    abstract class AbstractClass
    {
        //制定模板
        public  void PrimitiveOperation1()
        {
            Console.WriteLine("问题一:"+ ReturnAnswer1());

        }
        public void PrimitiveOperation2()
        {
            Console.WriteLine("问题二:"+ ReturnAnswer1());
        }


        public abstract string ReturnAnswer1();

        public abstract string ReturnAnswer2();

        public void Template()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }
    }
}
