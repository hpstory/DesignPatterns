using AbstractFactoryPattern.AbstractFactory.Employees;

namespace AbstractFactoryPattern.AbstractFactory.Interface
{
    internal interface IEmployee
    {
        void Insert(Employee employee);

        Employee GetEmployee(int id);
    }
}
