using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_State.Customer;

namespace Demo01_State
{
    class Program
    {
        static void Main(string[] args)
        {
            //紧急项目:
            var emergencyProjects = new Work();

            emergencyProjects.Hour = 9;
            emergencyProjects.WriteProgram();

            emergencyProjects.Hour = 10;
            emergencyProjects.WriteProgram();

            emergencyProjects.Hour = 12;
            emergencyProjects.WriteProgram();

            emergencyProjects.Hour = 13;
            emergencyProjects.WriteProgram();

            emergencyProjects.Hour = 14;
            emergencyProjects.WriteProgram();

            emergencyProjects.Hour = 17;
            //emergencyProjects.Finished = true;
            //emergencyProjects.Finished = false;
            emergencyProjects.WriteProgram();

            emergencyProjects.Hour = 19;
            emergencyProjects.WriteProgram();

            emergencyProjects.Hour = 22;
            emergencyProjects.WriteProgram();

            Console.ReadKey();
        }
    }
}
