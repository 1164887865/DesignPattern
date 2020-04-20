using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class HRDepartment : Company
    {
        public HRDepartment(string name) : base(name)
        {   }
        public override void Add(Company company)
        {   }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-',depth)+name); 
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0}员工招聘培训管理",name);
        }

        public override void Remove(Company company)
        {   }
    }
}
