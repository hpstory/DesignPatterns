# Singleton
## 概念
单例模式(Singleton), 保证一个类仅有一个实例, 并提供一个访问它的全局访问点.

## 前言
* 使用私有构造函数, 避免外部使用new创建类的实例


## 最简单的单例模式
```
SingletonPattern/SingleThread/Singleton.cs

internal sealed class Singleton
{
    private static Singleton instance;

    private Singleton()
    {
        Console.WriteLine("Created");
    }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
}
```
#### 缺点
多线程的程序中, 多个线程同时访问Singleton类中if语句的地方时, 会有可能造成创建多个实例.

## 多线程时的单例
```
SingletonPattern/Multithreading/Singleton.cs

internal sealed class Singleton
{
    // volatile 关键字指示一个字段可以由多个同时执行的线程修改.
    private static volatile Singleton instance;

    // 程序运行时创建一个静态只读的进程辅助对象
    private static readonly object instanceLock = new object();

    private Singleton()
    {
        Console.WriteLine("Created");
    }

    public static Singleton Instance
    {
        get
        {
            // 同一时刻只有一个线程可以进入
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }

            return instance;
        }
    }
}
```

#### 缺点
每次都需要lock影响性能

#### 改进
双重锁定, 先判断实例是否存在, 如果不存在的时候再加锁处理
```
SingletonPattern/Multithreading/Singleton.cs

internal sealed class Singleton
{
    private static volatile Singleton instance;

    private static readonly object instanceLock = new object();

    private Singleton()
    {
        Console.WriteLine("Created");
    }

    public static Singleton Instance
    {
        get
        {
            // double check locking
            if (instance == null)
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;
        }
    }
}
```

## 静态构造函数
利用C#的语法, 使用静态构造函数, 在第一次引用类的任何成员时创建实例, .NET运行时保证只调用一次静态构造函数.
```
SingletonPattern/StaticConstructor/Singleton.cs

internal sealed class Singleton
{
    public readonly static Singleton Instance = new Singleton();

    static Singleton()
    {
        Console.WriteLine("Created");
    }
}
```

#### 缺点
无法控制创建时机, 并且会提前占用系统资源

#### 改进
使用嵌套类, 创建实例的时候, 调用嵌套类的静态构造函数创建实例, 如果不调用属性, 就不会调用嵌套类, 也不会创建实例.
```
SingletonPattern/StaticConstructor/Singleton.cs

internal sealed class Singleton
{
    public static Singleton Instance
    {
        get
        {
            return Nested.Instance;
        }
    }

    private Singleton()
    {
    }

    class Nested
    {
        internal readonly static Singleton Instance = new Singleton();

        static Nested()
        {
            Console.WriteLine("Created");
        }
    }
}
```

## 延迟初始化---推荐
通过Lazy关键字, 声明的对象仅当第一次使用的时候, 再初始化, 如果一直没有调用, 就不初始化.

```
SingletonPattern/LazyType/Singleton.cs

internal sealed class Singleton
{
    private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

    private Singleton()
    {
        Console.WriteLine("Created");
    }

    public static Singleton Instance
    {
        get
        {
            return instance.Value;
        }
    }
}
```
