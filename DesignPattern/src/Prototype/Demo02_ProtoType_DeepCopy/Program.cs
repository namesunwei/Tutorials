using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_ProtoType_DeepCopy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Resume("大鸟");
            a.SetPersonalInfo("男", "29");
            a.SetWorkExperience("1998-2000", "XX公司");

            var b = (Resume)a.Clone();
            b.SetWorkExperience("1998-2006", "YY企业");

            var c = (Resume)a.Clone();
            c.SetPersonalInfo("男", "24");

            a.Display();
            b.Display();
            c.Display();

            Console.ReadKey();
            /*
            输出:
            大鸟 男 29
            工作经历: 1998 - 2000 XX公司
            大鸟 男 29
            工作经历: 1998 - 2006 YY企业
            大鸟 男 24
            工作经历: 1998 - 2000 XX公司
            */
        }
    }
}
