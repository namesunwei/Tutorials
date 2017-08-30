using System;
using Demo01_SimpleFactory.BaseClass;
using Demo01_SimpleFactory.DerivedClass;

namespace Demo01_SimpleFactory.FactoryClass
{
    /// <summary>
    /// 简单工厂类
    /// </summary>
    public class OperationFactory
    {
        public static Operation CreateOperate(string operate)
        {
            Operation oper;
            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
                default:
                    throw new Exception("暂不支持该运算方法");
            }
            return oper;
        }
    }
}
