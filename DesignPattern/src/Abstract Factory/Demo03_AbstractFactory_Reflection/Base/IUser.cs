using Demo03_AbstractFactory_Reflection.Models;

namespace Demo03_AbstractFactory_Reflection.Base
{
    /// <summary>
    /// 提供操作User表的方法接口
    /// </summary>
    interface IUser
    {
        void Insert(User user);
        User GetUser(int id);
    }
}
