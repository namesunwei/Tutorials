using System;
using Demo02_Proxy.BaseClass;

namespace Demo02_Proxy.DerivedClass
{
    /// <summary>
    /// Pursuit 类
    /// <remarks>真实对象</remarks>
    /// </summary>
    public class Pursuit : IGiveGift
    {
        public SchoolGirl MM { get; }

        public Pursuit(SchoolGirl girl)
        {
            MM = girl;
        }

        public void GiveChocolate()
        {
            Console.WriteLine($"{MM.Name},送你洋娃娃~");
        }

        public void GiveDolls()
        {
            Console.WriteLine($"{MM.Name},送你鲜花~");
        }

        public void GiveFlowers()
        {
            Console.WriteLine($"{MM.Name},送你巧克力~");
        }
    }
}
