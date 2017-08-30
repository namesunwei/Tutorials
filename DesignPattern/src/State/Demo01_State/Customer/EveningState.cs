using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_State.Base;

namespace Demo01_State.Customer
{
    class EveningState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Finished)
            {
                work.SetState(new RestState());
                work.WriteProgram();
            }
            else
            {
                if (work.Hour < 21)
                {
                    Console.WriteLine($"当前时间:{work.Hour}点.加班哦,疲惫至极~");
                }
                else
                {
                    work.SetState(new SleeppingState());
                    work.WriteProgram();
                }
            }
        }
    }
}
