using BuilderPattern;

Console.WriteLine("build wooden house");
var woodenHouse = new WoodenHouse();
var houseDirector = new HouseDirector(woodenHouse);
houseDirector.BuildHouse();

Console.WriteLine("build brick house");
var brickHouse = new BrickHouse();
houseDirector.ChangeBuilder(brickHouse);
houseDirector.BuildHouse();
