using AbstractFactoryPattern.AbstractFactory.Interface;
using System.Reflection;
using System.Configuration;

namespace AbstractFactoryPattern.ImproveAbstractFactory
{
    internal class DatabaseFactory
    {
        private static readonly string assemblyName = "AbstractFactoryPattern";

        private static readonly string database = ConfigurationManager.AppSettings["Database"];

        public static IEmployee CreateEmployee()
        {
            string className = $"{assemblyName}.AbstractFactory.Employees.{database}Employee";
            return Assembly.Load(assemblyName).CreateInstance(className) as IEmployee;
        }

        public static IDepartment CreateDepartment()
        {
            string className = $"{assemblyName}.AbstractFactory.Departments.{database}Department";
            return Assembly.Load(assemblyName).CreateInstance(className) as IDepartment;
        }
    }
}
