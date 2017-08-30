using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_State.Base;

namespace Demo01_State.Customer
{
    class NoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 13)
            {
                Console.WriteLine($"当前时间:{work.Hour}点.有点饿了,该吃午饭了,有点困,想小憩一会.");
            }
            else
            {
                work.SetState(new AfternoonState());
                work.WriteProgram(); ;
            }
        }
    }
}
