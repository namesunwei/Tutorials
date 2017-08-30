using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo02_FactoryMethod.BaseClass;
using Demo02_FactoryMethod.Factory;

namespace Demo02_FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("学雷锋的学生:");
            IFactory factory = new UndergroundFactory();
            var student = factory.CreateLeiFeng();
            student.BuyRice();
            student.Sweep();
            student.Wash();

            Console.WriteLine("****************************");

            Console.WriteLine("学雷锋的志愿者:");
            IFactory factory2 = new VolunterrFactory();
            var volunteer = factory2.CreateLeiFeng();
            volunteer.BuyRice();
            volunteer.Sweep();
            volunteer.Wash();

            Console.ReadKey();
        }
    }
}
