using System;

namespace Demo01_Facade
{
    /// <summary>
    /// 外观类
    /// <remarks>它需要了解所有子系统的方法和属性,进行组合,已被外界调用</remarks>
    /// </summary>
    internal class Facade
    {
        private readonly SubSystemOne _one;
        private readonly SubSystemTwo _two;
        private readonly SubSystemThree _three;
        private readonly SubSystemFour _four;

        public Facade()
        {
            _one = new SubSystemOne();
            _two = new SubSystemTwo();
            _three = new SubSystemThree();
            _four = new SubSystemFour(); ;
        }

        public void MethodA()
        {
            Console.WriteLine("\n 方法组A() ----");
            _one.MethodOne();
            _two.MethodTwo();
            _four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\n 方法组B() ----");
            _two.MethodTwo();
            _three.MethodThree();
            _four.MethodFour();
        }
    }
}
