using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_State.Base;

namespace Demo01_State.Customer
{
    class AfternoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 17)
            {
                Console.WriteLine($"当前时间:{work.Hour}点.下午状态还不错,继续努力!");
            }
            else
            {
                work.SetState(new EveningState());
                work.WriteProgram();
            }
        }
    }
}
