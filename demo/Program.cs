using System;
using System.IO;
using Newtonsoft.Json;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                Id = 1001,
                Name = "zsc",
                Categry = "Member"
            };
            var uStr = JsonConvert.SerializeObject(user);
            string path = @"f:\demo.txt";
            //if (!File.Exists(path))
            //{
            //    Console.WriteLine("开始创建文件...");
            //    using (StreamWriter sw = File.CreateText(path))
            //    {
            //        Console.WriteLine("创建完成，开始写入...");
            //        sw.WriteLine(uStr);
            //        Console.WriteLine("写入成功："+uStr);
            //    }
            //}
            //else 
            //{
            //    Console.WriteLine("开始读取...");
            //    StreamReader sr = File.OpenText(path);
            //    var userInso = JsonConvert.DeserializeObject<User>(sr.ReadToEnd());
            //    Console.WriteLine(userInso.Id +"  -  "+ userInso.Name +"  -  "+ userInso.Categry);
               
            //}
            Console.WriteLine("删除文件");
            File.Delete(path);
            Console.WriteLine("删除成功");
        }
    }
}
