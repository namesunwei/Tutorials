using Demo03_AbstractFactory_Reflection.Models;

namespace Demo03_AbstractFactory_Reflection.Base
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
