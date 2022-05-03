using AbstractFactoryPattern.AbstractFactory.Departments;
using AbstractFactoryPattern.AbstractFactory.Employees;
using AbstractFactoryPattern.AbstractFactory.Interface;

namespace AbstractFactoryPattern.AbstractFactory.Factory
{
    internal class SqlServerFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new SqlServerDepartment();
        }

        public IEmployee CreateEmployee()
        {
            return new SqlServerEmployee();
        }
    }
}
