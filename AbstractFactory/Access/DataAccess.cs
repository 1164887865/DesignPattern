using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AbstractFactory
{
    /// <summary>
    /// 创建各个数据库表对象的工厂
    /// 
    /// 放弃'Factory'文件下的工厂
    /// 将抽象工厂以及具体工厂转移到本类
    /// </summary>
    class DataAccess
    {
        private static readonly string AssemblyName = "AbstractFactory";
        //数据库
        private static string DB = "";
        /// <summary>
        /// 设置操作库
        /// </summary>
        /// <param name="db">Sql|Access|Orcle（大小写敏感）</param>
        public DataAccess(string db)
        {
            DB = db;
        }
        public IUser CreateUser()
        {
            string className = AssemblyName + "." + DB + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public IDepartment CreateDepartment()
        {
            string className = AssemblyName + "." + DB + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }

    }
}
