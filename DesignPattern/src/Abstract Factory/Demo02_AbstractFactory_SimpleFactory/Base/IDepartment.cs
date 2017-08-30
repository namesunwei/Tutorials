using Demo02_AbstractFactory_SimpleFactory.Models;

namespace Demo02_AbstractFactory_SimpleFactory.Base
{
    /// <summary>
    /// 提供操作Department表方法的接口
    /// </summary>
    interface IDepartment
    {
        void Insert(Department department);
        Department GetDepartment(int id);

    }
}
