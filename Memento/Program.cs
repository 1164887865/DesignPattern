using Memento.demo;
using System;

namespace Memento
{
    class Program
    {
        /// <summary>
        /// originator是需要备份的对象
        /// caretaker是管理员，用来存放会改变的对象，可在改变后获取之前记录的值
        /// memento备忘录，里面有一个自定义类型属性
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            {
                ////初始化源 设置需要记录的状态
                ////Member member = new Member() { Name = "zz", Leve = 99 };
                //Originator originator = new Originator();
                //originator.State = "ON";//ON
                //originator.Show();
                ////初始化管理者 将需要记录的状态给管理员
                //Caretaker caretaker = new Caretaker();
                //caretaker.memento = originator.CreateMemento();
                ////状态改变
                //originator.State = "OFF";
                //originator.Show();//OFF
                ////将之前给管理员的备份重新还原
                //originator.SetMemento(caretaker.memento);
                //originator.Show();//ON

                //Console.ReadKey();
            }

            {
                //设置值
                RoleStateOrigin stateOrigin = new RoleStateOrigin();
                stateOrigin.Name = "zz";
                stateOrigin.Level = 99;
                stateOrigin.Show();
                //保存
                RoleStateCaretaker caretaker = new RoleStateCaretaker();
                caretaker.memento = stateOrigin.SaveState();
                //改变
                stateOrigin.Level += 1;
                stateOrigin.Show();
                //恢复
                stateOrigin.SetState(caretaker.memento);
                stateOrigin.Show();

                Console.ReadKey();

            }
        }
    }
}
