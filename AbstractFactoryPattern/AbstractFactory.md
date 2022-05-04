# Abstract Factory

### 概念
抽象工厂模式(Abstract Factory), 提供一个创建一系列相关或互相依赖的接口，而无需指定它们具体的类。

### 优点
* 当一个系列中的多个对象被设计成一起工作时，它能保证客户端始终只使用同一个系列中的对象。

### 缺点
* 如果没有多系列对象构建的需求变化时，使用简单的静态工厂完全可以。
* 抽象工厂模式主要用于新系列的需求变动，不适用于新对象的需求变动，如增加新的实体类型Project，需要增加IProject, SqlServerProject, OracleProject, 还需要修改IFactory, SqlServerFactory, OracleFactory。
* 在`Program.cs`中需要声明数据库的类型，如果有多处需要调用数据库访问的类，则每处都需要进行修改。


### 利用反射+简单工厂模式优化
去除IFactory, SqlServerFactory, OracleFactory三个工厂类，使用DatabaseFactory类替代，这样客户端就不会出现任何一个数据库类型的字样。利用反射去除分支判断带来的耦合，加入配置文件解决更改数据库的问题。

```
// AbstractFactoryPattern/ImproveAbstractFactory/DatabaseFactory.cs

internal class DatabaseFactory
{
    private static readonly string assemblyName = "AbstractFactoryPattern";

    private static readonly string database = ConfigurationManager.AppSettings["Database"];

    public static IEmployee CreateEmployee()
    {
        string className = $"{assemblyName}.AbstractFactory.Employees.{database}Employee";
        return Assembly.Load(assemblyName).CreateInstance(className) as IEmployee;
    }

    public static IDepartment CreateDepartment()
    {
        string className = $"{assemblyName}.AbstractFactory.Departments.{database}Department";
        return Assembly.Load(assemblyName).CreateInstance(className) as IDepartment;
    }
}
```

```
// AbstractFactoryPattern/Program.cs

Console.WriteLine("Improve Abstract Factory");
Employee employee = new Employee();
Department department = new Department();

IEmployee iEmployee = DatabaseFactory.CreateEmployee();
iEmployee.Insert(employee);
iEmployee.GetEmployee(1);

IDepartment iDepartment = DatabaseFactory.CreateDepartment();
iDepartment.Insert(department);
iDepartment.GetDepartment(1);
```
