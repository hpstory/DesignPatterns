namespace SingletonPattern.SingleThread
{
    internal class Singleton
    {
        private static Singleton instance;

        // 私有构造函数，外部代码不能通过new来实例化
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

    public class Test
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
            Console.WriteLine(s1.Equals(s2));
        }
    }
}
