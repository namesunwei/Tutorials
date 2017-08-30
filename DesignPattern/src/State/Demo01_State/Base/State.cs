using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_State.Customer;

namespace Demo01_State.Base
{
    internal abstract class State
    {
        public abstract void WriteProgram(Work work);
    }
}
