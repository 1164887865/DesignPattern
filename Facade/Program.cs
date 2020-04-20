using System;

namespace Facade
{
    class Program
    {
        /// <summary>
        ///     门面模式
        /// 在设计之初用，将不同的两个层分离
        /// 经典的三层结构就需要考虑数据访问层和业务逻辑层、业务逻辑层和表示层的层与层建立外观；
        /// 优点：提供接口以减少依赖，使代码脉络清晰，简单化复杂的工作。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            FacadeClass facadeClass = new FacadeClass();
            facadeClass.getSub();
        }
    }
}
