using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_State.Base;

namespace Demo01_State.Customer
{
    class RestState : State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine($"当前时间:{work.Hour}点. 下班回家咯~");
        }
    }
}
