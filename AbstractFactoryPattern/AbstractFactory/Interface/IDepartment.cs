using AbstractFactoryPattern.AbstractFactory.Departments;

namespace AbstractFactoryPattern.AbstractFactory.Interface
{
    internal interface IDepartment
    {
        void Insert(Department department);

        Department GetDepartment(int id);
    }
}
