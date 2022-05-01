namespace SingletonPattern.LazyType
{
    internal class Singleton
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
}
