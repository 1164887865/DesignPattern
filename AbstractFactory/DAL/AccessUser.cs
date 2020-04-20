using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /// <summary>
    /// 使access操作类实现IUser接口
    /// </summary>
    class AccessUser : IUser
    {
        public void Delete(int id)
        {
            Console.WriteLine($"Access - 删除ID为{0}的用户", id);
        }

        public User GetUser(int id)
        {
            Console.WriteLine($"Access - 查询ID为{0}的用户", id);
            return null;
        }

        public void InSert(User user)
        {
            Console.WriteLine($"Access - 插入一个用户");
        }

        public void Update(User user)
        {
            Console.WriteLine($"Access - 更新一个用户");
        }
    }
}
