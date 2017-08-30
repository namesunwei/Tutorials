using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo02_AbstractFactory_SimpleFactory.Base;
using Demo02_AbstractFactory_SimpleFactory.Customer;

namespace Demo02_AbstractFactory_SimpleFactory.Factory
{
    class DataAccess
    {
        //private static readonly string _db = "Access";
        private static readonly string _db = "SqlServer";

        public static IUser CreateUser()
        {
            IUser result = null;
            switch (_db)
            {
                case "SqlServer":
                    result = new SqlServerUser();
                    break;
                case "Access":
                    result = new AccessUser();
                    break;
            }
            return result;
        }

        public static IDepartment CreateDepartment()
        {
            IDepartment result = null;
            switch (_db)
            {
                case "SqlServer":
                    result = new SqlServerDepartment();
                    break;
                case "Access":
                    result = new AccessDepartment();
                    break;
            }
            return result;
        }
    }
}
