using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /// <summary>
    /// 抽象类
    /// </summary>
    interface IFactory
    {
        IUser CreaterUser();
        IDepartment CreateDepartment();
    }
}
