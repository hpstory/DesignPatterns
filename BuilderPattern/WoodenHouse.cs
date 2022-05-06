namespace BuilderPattern
{
    internal class WoodenHouse : IHouseBuilder
    {
        public void BuildCeiling()
        {
            Console.WriteLine("build wooden ceiling");
        }

        public void BuildDoor()
        {
            Console.WriteLine("build wooden door");
        }

        public void BuildFloor()
        {
            Console.WriteLine("build wooden floor");
        }

        public void BuildWall()
        {
            Console.WriteLine("build wooden wall");
        }

        public void BuildWindows()
        {
            Console.WriteLine("build windows");
        }
    }
}
