# Prototype Pattern

### 概念
用原型实例指定创建对象的种类, 并且通过拷贝这些原型创建新的对象.

### 本质
从一个对象在创建另外一个可定制的对象, 而且不需要知道任何创建的细节.

### ICloneable
在.NET中不需要创建原型抽象类, 使用ICloneable接口即可

### MemberwiseClone
* 创建当前对象的浅表拷贝
* 创建一个新对象, 然后将当前对象的非静态字段复制到该新对象.
* 如果字段是值类型, 则对该字段执行逐位复制.
* 如果字段是引用类型, 则复制引用, 但不复制引用的对象. 可以对引用类型使用ICloneable, 并且在最终的实现对象中使用深拷贝.
```
// PrototypePattern/CSharpPrototype/Resume.cs

private Resume(Education education)
{
	this.Education = (Education)education.Clone();
}
...
public object Clone()
{
	Resume resume = new Resume(this.Education);
	resume.Name = this.Name;
	resume.Company = this.Company;
	return resume;
}
```

### 优点
* 避免初始化构造函数, 可以提高性能, 同时隐藏对象创建的细节