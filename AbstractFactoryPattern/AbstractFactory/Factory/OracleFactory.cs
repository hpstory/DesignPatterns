using AbstractFactoryPattern.AbstractFactory.Departments;
using AbstractFactoryPattern.AbstractFactory.Employees;
using AbstractFactoryPattern.AbstractFactory.Interface;

namespace AbstractFactoryPattern.AbstractFactory.Factory
{
    internal class OracleFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new OracleDepartment();
        }

        public IEmployee CreateEmployee()
        {
            return new OracleEmployee();
        }
    }
}
