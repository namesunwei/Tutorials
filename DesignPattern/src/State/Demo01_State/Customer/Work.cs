using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_State.Base;

namespace Demo01_State.Customer
{
    internal class Work
    {
        private State _current;
        public double Hour { get; set; }
        public bool Finished { get; set; }
        public Work()
        {
            _current = new ForenoonState();
        }

        public void SetState(State state)
        {
            _current = state;
        }

        public void WriteProgram()
        {
            _current.WriteProgram(this);
        }

    }
}
