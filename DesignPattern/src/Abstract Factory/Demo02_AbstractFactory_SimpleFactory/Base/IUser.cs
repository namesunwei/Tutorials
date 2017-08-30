using Demo02_AbstractFactory_SimpleFactory.Models;

namespace Demo02_AbstractFactory_SimpleFactory.Base
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
