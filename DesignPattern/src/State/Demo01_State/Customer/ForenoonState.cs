using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_State.Base;

namespace Demo01_State.Customer
{
    class ForenoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour<12)
            {
                Console.WriteLine($"当前时间{work.Hour}点,上午工作,精神倍儿棒!");
            }
            else
            {
                work.SetState(new NoonState());
                work.WriteProgram();
            }
        }
    }
}
