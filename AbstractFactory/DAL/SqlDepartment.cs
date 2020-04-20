using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /// <summary>
    /// 用sql操作类实现部门类接口
    /// </summary>
    class SqlDepartment : IDepartment
    {
        public void Delete(int id)
        {
            Console.WriteLine($"SQL - 删除ID为{0}的部门", id);
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine($"SQL - 查询ID为{0}的部门", id);
            return null;
        }

        public void InSert(Department department)
        {
            Console.WriteLine($"SQL - 插入一个部门");
        }

        public void Update(Department department)
        {
            Console.WriteLine($"SQL - 更新一个更新");
        }
    }
}
