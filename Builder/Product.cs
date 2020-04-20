using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Product
    {
        IList<string> parts = new List<string>();
        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("开始创建产品");
            foreach (var item in parts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
