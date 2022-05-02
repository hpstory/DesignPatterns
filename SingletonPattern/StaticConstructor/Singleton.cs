namespace SingletonPattern.StaticConstructor
{
    //internal sealed class Singleton
    //{
    //    public readonly static Singleton Instance = new Singleton();

    //    static Singleton()
    //    {
    //        Console.WriteLine("Created");
    //    }
    //}

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
}
