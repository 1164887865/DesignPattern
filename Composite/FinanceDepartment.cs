using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// 财务部
    /// </summary>
    class FinanceDepartment : Company
    {
        public FinanceDepartment(string name) : base(name)
        {
            
        }
        public override void Add(Company company)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-',depth)+name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0}公司财务收支管理",name);
        }

        public override void Remove(Company company)
        {
        }
    }
}
