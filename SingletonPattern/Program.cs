{
    Console.WriteLine("Single Thread!");
    SingletonPattern.SingleThread.Singleton s1 = SingletonPattern.SingleThread.Singleton.Instance;
    SingletonPattern.SingleThread.Singleton s2 = SingletonPattern.SingleThread.Singleton.Instance;
    Console.WriteLine(s1.Equals(s2)); // ture
}
{
    Console.WriteLine("Multithreading!");
    int total = 10000;
    Task[] tasks = new Task[total];
    for (int i = 0; i < total; i++)
    {
        tasks[i] = Task.Factory.StartNew(() =>
        {
            SingletonPattern.Multithreading.Singleton singleton = SingletonPattern.Multithreading.Singleton.Instance;
        });
    }
    Task.WaitAll(tasks);
}
{
    Console.WriteLine("Static Constructor!");
    int total = 10000;
    Task[] tasks = new Task[total];
    for (int i = 0; i < total; i++)
    {
        tasks[i] = Task.Factory.StartNew(() =>
        {
            SingletonPattern.StaticConstructor.Singleton singleton = SingletonPattern.StaticConstructor.Singleton.Instance;
        });
    }
    Task.WaitAll(tasks);
}
{
    Console.WriteLine("Lazy Type!");
    int total = 10000;
    Task[] tasks = new Task[total];
    for (int i = 0; i < total; i++)
    {
        tasks[i] = Task.Factory.StartNew(() =>
        {
            SingletonPattern.LazyType.Singleton singleton = SingletonPattern.LazyType.Singleton.Instance;
        });
    }
    Task.WaitAll(tasks);
}
