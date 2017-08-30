using System;
using Demo03_AbstractFactory_Reflection.Base;
using Demo03_AbstractFactory_Reflection.Models;

namespace Demo03_AbstractFactory_Reflection.Customer
{
    /// <summary>
    /// SqlServer数据库操作User表的类
    /// </summary>
    class SqlServerUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在SQLServer中根据Id得到User表的一条记录.");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("在SQLServer中给User表增加一条记录.");
        }
    }
}
