using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    abstract class Company
    {
        protected string name;

        public Company(string name)
        {
            this.name = name;
        }

        public abstract void Add(Company company);//增加
        public abstract void Remove(Company company);//移除
        public abstract void Display(int depth);//显示
        public abstract void LineOfDuty();//履行职责
    }
}
