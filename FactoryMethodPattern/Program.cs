using FactoryMethodPattern;

IVehicleFactory factory = new CarFactory();
// IVehicleFactory factory = new TruckFactory();

Vehicle vehicle = factory.TestVehicle("car");
vehicle.StartUp();
vehicle.Run();
vehicle.Stop();
