using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_Strategy.BaseClass;

namespace Demo01_Strategy.ContextClass
{
    /// <summary>
    /// 策略模式的上下文类
    /// <remarks>用于创建具体的算法类</remarks>
    /// </summary>
    public class Context
    {
        private readonly Strategy _strategy;
        /// <summary>
        /// 初始化时,传入具体的策略对象
        /// </summary>
        /// <param name="strategy"></param>
        public Context(Strategy strategy)
        {
            _strategy = strategy;
        }
        /// <summary>
        /// 根据具体的策略对象,调用其算法的方法
        /// </summary>
        public void ContextInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
}
