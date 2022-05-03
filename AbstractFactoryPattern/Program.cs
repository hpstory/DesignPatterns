using AbstractFactoryPattern.AbstractFactory.Departments;
using AbstractFactoryPattern.AbstractFactory.Employees;
using AbstractFactoryPattern.AbstractFactory.Factory;
using AbstractFactoryPattern.AbstractFactory.Interface;
using AbstractFactoryPattern.ImproveAbstractFactory;
//{
//    Console.WriteLine("Abstract Factory");
//    Employee employee = new Employee();
//    Department department = new Department();

//    // IFactory factory = new SqlServerFactory();
//    IFactory factory = new OracleFactory();

//    IEmployee iEmployee = factory.CreateEmployee();
//    iEmployee.Insert(employee);
//    iEmployee.GetEmployee(1);

//    IDepartment iDepartment = factory.CreateDepartment();
//    iDepartment.Insert(department);
//    iDepartment.GetDepartment(1);
//}
{
    Console.WriteLine("Improve Abstract Factory");
    Employee employee = new Employee();
    Department department = new Department();

    IEmployee iEmployee = DatabaseFactory.CreateEmployee();
    iEmployee.Insert(employee);
    iEmployee.GetEmployee(1);

    IDepartment iDepartment = DatabaseFactory.CreateDepartment();
    iDepartment.Insert(department);
    iDepartment.GetDepartment(1);
}
