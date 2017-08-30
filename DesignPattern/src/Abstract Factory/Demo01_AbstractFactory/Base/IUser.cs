using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_AbstractFactory.Models;

namespace Demo01_AbstractFactory.Base
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
