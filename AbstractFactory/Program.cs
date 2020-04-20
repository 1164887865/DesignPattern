using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ////实例化sql工厂
            //IFactory factory = new SqlFactory();

            ////用sql工厂创建具体操作类
            //IUser sqluser = factory.CreaterUser();
            //IDepartment sqldepartment = factory.CreateDepartment();
            ////数据库操作类
            //sqluser.GetUser(101);
            //sqluser.Delete(101);
            //sqluser.InSert(new User() { Id = 1002,Name="zzz",Age=18 });
            //sqluser.Update(new User() { Id = 1002, Name = "zssz", Age = 18 });
            //sqldepartment.GetDepartment(101);
            //sqldepartment.Delete(101);
            //sqldepartment.InSert(new Department() { Id = 1101, dName = "技术部" });
            //sqldepartment.Update(new Department() { Id = 1002, dName = "开发部" });



            ////实例化access工厂
            //IFactory factory1 = new AccessFactory();

            ////用access工厂创建具体操作类
            //IUser accessuser = factory1.CreaterUser();
            //IDepartment accessdepartment = factory1.CreateDepartment();
            ////数据库操作类
            //accessuser.GetUser(101);
            //accessuser.Delete(101);
            //accessuser.InSert(new User() { Id = 1002, Name = "zzz", Age = 18 });
            //accessuser.Update(new User() { Id = 1002, Name = "zssz", Age = 18 });
            //accessdepartment.GetDepartment(101);
            //accessdepartment.Delete(101);
            //accessdepartment.InSert(new Department() { Id = 1101, dName = "技术部" });
            //accessdepartment.Update(new Department() { Id = 1002, dName = "开发部" });


            //使用反射创造 sql创造对象
            DataAccess sqlaccess = new DataAccess("Sql");
            //创造表对象
            IUser sqlUser = sqlaccess.CreateUser();
            IDepartment sqlDepartment = sqlaccess.CreateDepartment();

            sqlUser.Delete(101);
            sqlDepartment.GetDepartment(1101);

            //使用反射创造 access创造对象
            DataAccess access = new DataAccess("Access");
            //创建表对象
            IUser accessUser = access.CreateUser();
            IDepartment accessDepartment = access.CreateDepartment();

            accessUser.GetUser(101);
            accessDepartment.GetDepartment(1101);

            DataAccess orcleaccess = new DataAccess("Orcle");
            var a = orcleaccess.CreateUser();

            Console.WriteLine(a);
            Console.ReadLine();

        }
    }
}
