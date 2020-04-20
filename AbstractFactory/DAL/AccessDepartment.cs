using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /// <summary>
    /// 使用access操作类实现部门类接口
    /// </summary>
    class AccessDepartment:IDepartment
    {
        public void Delete(int id)
        {
            Console.WriteLine($"Access - 删除ID为{0}的部门", id);
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine($"Access - 查询ID为{0}的部门", id);
            return null;
        }

        public void InSert(Department department)
        {
            Console.WriteLine($"Access - 插入一个部门");
        }

        public void Update(Department department)
        {
            Console.WriteLine($"Access - 更新一个部门");
        }
    }
}
