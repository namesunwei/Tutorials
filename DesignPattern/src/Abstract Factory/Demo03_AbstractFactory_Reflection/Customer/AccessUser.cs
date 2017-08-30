using System;
using Demo03_AbstractFactory_Reflection.Base;
using Demo03_AbstractFactory_Reflection.Models;

namespace Demo03_AbstractFactory_Reflection.Customer
{
    /// <summary>
    /// Access数据库操作User表的类
    /// </summary>
    class AccessUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在Access中根据Id得到User表的一条记录.");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("在Access中给User表增加一条记录.");
        }
    }
}
