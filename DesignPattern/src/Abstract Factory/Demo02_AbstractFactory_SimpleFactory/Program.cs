using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo02_AbstractFactory_SimpleFactory.Base;
using Demo02_AbstractFactory_SimpleFactory.Factory;
using Demo02_AbstractFactory_SimpleFactory.Models;

namespace Demo02_AbstractFactory_SimpleFactory
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
