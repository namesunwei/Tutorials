using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo03_AbstractFactory_Reflection.Models;
using Demo03_AbstractFactory_Reflection.Reflection;

namespace Demo03_AbstractFactory_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            var department = new Department();

            var iu = DataAccess.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            var id = DataAccess.CreateDepartment();
            id.Insert(department);
            id.GetDepartment(1);

            Console.ReadKey();
        }
    }
}
