using AbstractFactoryPattern.AbstractFactory.Interface;

namespace AbstractFactoryPattern.AbstractFactory.Departments
{
    internal class OracleDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("Get department from oracle");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("Create a department in oracle");
        }
    }
}
