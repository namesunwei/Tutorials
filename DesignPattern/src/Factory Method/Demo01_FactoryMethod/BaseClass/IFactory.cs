namespace Demo01_FactoryMethod.BaseClass
{
    /// <summary>
    /// 工厂接口
    /// <remarks>在继承该接口的工厂类中实例化具体操作方法</remarks>
    /// </summary>
    public interface IFactory
    {
        Operation CreateOperation();
    }
}
