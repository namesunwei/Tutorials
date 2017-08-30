using System;
using Demo01_SimpleFactory.FactoryClass;

namespace Demo01_SimpleFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string strNumA;
            double numA;
            do
            {
                Console.WriteLine("请输入数字A:");
                strNumA = Console.ReadLine();
            }
            while (!double.TryParse(strNumA, out numA));

            //Console.WriteLine("请输入运算符(+,-,*,/):");
            //var strOperate = Console.ReadLine();

            string strOperate;
            do
            {
                Console.WriteLine("请输入运算符(+,-,*,/):");
                strOperate = Console.ReadLine();
            }
            while (strOperate != "+" && strOperate != "-" && strOperate != "*" && strOperate != "/");

            string strNumB;
            double numB;
            do
            {
                Console.WriteLine("请输入数字B:");
                strNumB = Console.ReadLine();
            }
            while (!double.TryParse(strNumB, out numB));
            try
            {
                var operation = OperationFactory.CreateOperate(strOperate);
                operation.NumberA = numA;
                operation.NumberB = numB;
                Console.WriteLine($"{numA}{strOperate}{numB}={operation.GetResult()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
