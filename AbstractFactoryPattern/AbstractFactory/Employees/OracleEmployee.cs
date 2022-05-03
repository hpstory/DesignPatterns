using AbstractFactoryPattern.AbstractFactory.Interface;

namespace AbstractFactoryPattern.AbstractFactory.Employees
{
    internal class OracleEmployee : IEmployee
    {
        public Employee GetEmployee(int id)
        {
            Console.WriteLine("Get employee from oracle");
            return null;
        }

        public void Insert(Employee employee)
        {
            Console.WriteLine("Create an employee in oracle");
        }
    }
}
