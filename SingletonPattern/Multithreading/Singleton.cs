namespace SingletonPattern.Multithreading
{
    internal sealed class Singleton
    {
        // volatile 关键字指示一个字段可以由多个同时执行的线程修改。
        private static volatile Singleton instance;

        // 程序运行时创建一个静态只读的进程辅助对象
        private static readonly object instanceLock = new object();

        private Singleton()
        {
            Console.WriteLine("Created");
        }

        //public static Singleton Instance
        //{
        //    get
        //    {
        //        // 同一时刻只有一个线程可以进入
        //        lock (instanceLock)
        //        {
        //            if (instance == null)
        //            {
        //                instance = new Singleton();
        //            }
        //        }

        //        return instance;
        //    }
        //}

        public static Singleton Instance
        {
            get
            {
                // double check locking
                if (instance == null)
                {
                    // 同一时刻只有一个线程可以进入
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
}
