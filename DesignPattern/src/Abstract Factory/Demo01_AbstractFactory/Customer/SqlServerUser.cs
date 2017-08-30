using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_AbstractFactory.Base;
using Demo01_AbstractFactory.Models;

namespace Demo01_AbstractFactory.Customer
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
