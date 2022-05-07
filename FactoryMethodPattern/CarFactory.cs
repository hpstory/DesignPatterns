namespace FactoryMethodPattern
{
    internal class CarFactory : IVehicleFactory
    {
        public Vehicle TestVehicle(string type)
        {
            Console.WriteLine($"Test {type}");
            return new Car();
        }
    }
}
