using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /// <summary>
    /// 具体工厂
    /// </summary>
    class SqlFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new SqlDepartment(); 
        }

        public IUser CreaterUser()
        {
            return new SqlUser();
        }
    }
}
