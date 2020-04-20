using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /// <summary>
    /// 用户操作类接口
    /// </summary>
    interface IUser
    {
        User GetUser(int id);

        void InSert(User user);

        void Update(User user);

        void Delete(int id);
    }
}
