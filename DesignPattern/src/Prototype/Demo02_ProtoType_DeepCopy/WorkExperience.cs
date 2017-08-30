using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02_ProtoType_DeepCopy
{
    internal class WorkExperience : ICloneable
    {
        public string WorkDate { get; set; }
        public string Company { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
