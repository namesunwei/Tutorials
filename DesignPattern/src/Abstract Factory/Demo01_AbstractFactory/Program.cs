using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_AbstractFactory.Base;
using Demo01_AbstractFactory.Factory;
using Demo01_AbstractFactory.Models;

namespace Demo01_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            var department = new Department();

            //IFactory factory = new AccessFactory();
            var factory = new SQLServerFactory();

            var userManager = factory.CreateUser();

            userManager.Insert(user);
            userManager.GetUser(1);

            var departmentManager = factory.CreateDepartment();

            departmentManager.Insert(department);
            departmentManager.GetDepartment(1);

            Console.ReadKey();

        }
    }
}
