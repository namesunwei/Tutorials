using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo01_AbstractFactory.Base;
using Demo01_AbstractFactory.Customer;

namespace Demo01_AbstractFactory.Factory
{
    class AccessFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new AccessDepartment(); ;
        }

        public IUser CreateUser()
        {
            return new AccessUser();
        }
    }
}
