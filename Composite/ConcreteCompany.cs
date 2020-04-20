using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// 具体类
    /// </summary>
    class ConcreteCompany : Company
    {
        private List<Company> children = new List<Company>();
        public ConcreteCompany(string name) : base(name)
        {
            
        }
        public override void Add(Company company)
        {
            children.Add(company);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-',depth)+name);
            foreach (Company company in children)
            {
                company.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (Company company1 in children)
            {
                company1.LineOfDuty();
            }
        }

        public override void Remove(Company company)
        {
            children.Remove(company);
        }
    }
}
