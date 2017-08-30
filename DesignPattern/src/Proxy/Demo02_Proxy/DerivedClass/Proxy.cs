using Demo02_Proxy.BaseClass;

namespace Demo02_Proxy.DerivedClass
{
    /// <summary>
    /// Proxy 类
    /// <remarks>代理类,获取一个真实实体对象,调用该对象的方法</remarks>
    /// </summary>
    public class Proxy : IGiveGift
    {
        public Pursuit GG { get; }

        public Proxy(SchoolGirl schoolGirl)
        {
            GG = new Pursuit(schoolGirl);
        }

        public void GiveDolls()
        {
            GG.GiveDolls();
        }

        public void GiveFlowers()
        {
            GG.GiveFlowers();
        }

        public void GiveChocolate()
        {
            GG.GiveChocolate();
        }
    }
}
