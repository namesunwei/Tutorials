using System.Configuration;
using System.Reflection;
using Demo03_AbstractFactory_Reflection.Base;

namespace Demo03_AbstractFactory_Reflection.Reflection
{
    class DataAccess
    {
        private static readonly string AssemblyName = "Demo03_AbstractFactory_Reflection";
        private static readonly string DbType = ConfigurationManager.AppSettings["DbType"];

        public static IUser CreateUser()
        {
            string className = AssemblyName + ".Customer" + "." + DbType + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDepartment CreateDepartment()
        {
            string className = AssemblyName + ".Customer" + "." + DbType + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
