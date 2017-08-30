using System;
using Demo02_AbstractFactory_SimpleFactory.Base;
using Demo02_AbstractFactory_SimpleFactory.Models;

namespace Demo02_AbstractFactory_SimpleFactory.Customer
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
