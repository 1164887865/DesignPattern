using System;
using System.Collections;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 根节点
            ConcreteCompany root = new ConcreteCompany("北京总公司");
            root.Add(new HRDepartment("总公司人力资源部"));
            root.Add(new HRDepartment("总公司财务部"));

            ConcreteCompany company1 = new ConcreteCompany("上海华东分公司");
            company1.Add(new HRDepartment("华东分公司人力资源部"));
            company1.Add(new HRDepartment("华东分公司财务部"));
            root.Add(company1);

            ConcreteCompany company2 = new ConcreteCompany("南京办事处");
            company2.Add(new HRDepartment("南京办事处人力资源部"));
            company2.Add(new HRDepartment("南京办事处财务部"));
            company1.Add(company2);

            ConcreteCompany company3 = new ConcreteCompany("杭州办事处");
            company3.Add(new HRDepartment("杭州办事处人力资源部"));
            company3.Add(new HRDepartment("杭州办事处财务部"));
            company1.Add(company3);
            #endregion


            Console.WriteLine("\n 结构图");
            root.Display(1);

            Console.WriteLine("\n 职责");
            root.LineOfDuty();



            Console.ReadKey();

        }
    }
}
