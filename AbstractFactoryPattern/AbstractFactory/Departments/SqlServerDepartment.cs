using AbstractFactoryPattern.AbstractFactory.Interface;

namespace AbstractFactoryPattern.AbstractFactory.Departments
{
    internal class SqlServerDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("Get department from sqlserver");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("Create a department in sqlserver");
        }
    }
}
