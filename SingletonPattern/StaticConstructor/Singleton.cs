namespace SingletonPattern.StaticConstructor
{
    internal sealed class Singleton
    {
        public readonly static Singleton Instance = new Singleton();

        static Singleton()
        {
            Console.WriteLine("Created");
        }
    }
}
