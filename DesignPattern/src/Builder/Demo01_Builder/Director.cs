using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_Builder.BaseClass;

namespace Demo01_Builder
{
    /// <summary>
    /// Director 类
    /// <remarks>指挥者类</remarks>
    /// </summary>
    internal class Director
    {
        /// <summary>
        /// 用来指挥建造过程
        /// </summary>
        /// <param name="builder"></param>
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
