namespace FactoryMethodPattern
{
    public class Vehicle
    {
        public void Run()
        {
            Console.WriteLine("run");
        }

        public void StartUp()
        {
            Console.WriteLine("start up");
        }

        public void Stop()
        {
            Console.WriteLine("stop");
        }
    }
}
