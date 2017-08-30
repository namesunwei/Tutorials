using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_Observer_delegate.Base
{
    public interface ISubject
    {
        string SubjectState { get; set; }
        void Notify();
    }

}
