namespace Demo01_Builder.BaseClass
{
    /// <summary>
    /// Builder 类
    /// <remarks>抽象建造者类</remarks>
    /// </summary>
    internal abstract class Builder
    {
        internal abstract void BuildPartA();
        internal abstract void BuildPartB();
        internal abstract Product GetResult();
    }
}
