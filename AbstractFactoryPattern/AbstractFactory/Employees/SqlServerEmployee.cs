using AbstractFactoryPattern.AbstractFactory.Interface;

namespace AbstractFactoryPattern.AbstractFactory.Employees
{
    internal class SqlServerEmployee : IEmployee
    {
        public Employee GetEmployee(int id)
        {
            Console.WriteLine("Get employee from sqlserver");
            return null;
        }

        public void Insert(Employee employee)
        {
            Console.WriteLine("Create an employee in sqlserver");
        }
    }
}
