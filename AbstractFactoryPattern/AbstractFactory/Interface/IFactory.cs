namespace AbstractFactoryPattern.AbstractFactory.Interface
{
    internal interface IFactory
    {
        IEmployee CreateEmployee();

        IDepartment CreateDepartment();
    }
}
