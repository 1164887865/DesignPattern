using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /// <summary>
    /// 使用sql操作类实现用户类接口
    /// </summary>
    class SqlUser : IUser
    {
        public void Delete(int id)
        {
            Console.WriteLine($"SQL - 删除ID为{0}的用户",id);
        }

        public User GetUser(int id)
        {
            Console.WriteLine($"SQL - 查询ID为{0}的用户",id);
            return null;
        }

        public void InSert(User user)
        {
            Console.WriteLine($"SQL - 插入一个用户");
        }

        public void Update(User user)
        {
            Console.WriteLine($"SQL - 更新一个用户");
        }
    }
}
