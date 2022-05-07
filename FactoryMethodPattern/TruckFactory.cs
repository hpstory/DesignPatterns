namespace FactoryMethodPattern
{
    internal class TruckFactory : IVehicleFactory
    {
        public Vehicle TestVehicle(string type)
        {
            Console.WriteLine($"Test {type}");
            return new Truck();
        }
    }
}
