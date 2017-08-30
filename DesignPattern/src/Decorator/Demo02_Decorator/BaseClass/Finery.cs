namespace Demo02_Decorator.BaseClass
{
    /// <summary>
    /// 服装类
    /// <remarks>相当于Decorator类</remarks>
    /// </summary>
    public class Finery : Person
    {
        protected Person Component;

        public void Decorate(Person person)
        {
            Component = person;
        }

        public override void ShowStyle()
        {
            Component?.ShowStyle();
        }
    }
}
