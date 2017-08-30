using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo01_Observer.Base
{
    /// <summary>
    /// 通知者接口
    /// </summary>
    public interface ISubject
    {
        string SubjectState { get; set; }

        void Attach(Observer observer);

        void Detach(Observer observer);

        void Notify();

    }
}
