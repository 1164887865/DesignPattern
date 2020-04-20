using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface IDepartment
    {
        Department GetDepartment(int id);

        void InSert(Department department);

        void Update(Department department);

        void Delete(int id);
    }
}
