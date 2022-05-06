namespace BuilderPattern
{
    internal class BrickHouse : IHouseBuilder
    {
        public void BuildCeiling()
        {
            Console.WriteLine("build brick ceiling");
        }

        public void BuildDoor()
        {
            Console.WriteLine("no door");
        }

        public void BuildFloor()
        {
            Console.WriteLine("build brick floor");
        }

        public void BuildWall()
        {
            Console.WriteLine("build brick wall");
        }

        public void BuildWindows()
        {
            Console.WriteLine("no window");
        }
    }
}
