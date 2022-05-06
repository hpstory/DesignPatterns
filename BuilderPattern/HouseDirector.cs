namespace BuilderPattern
{
    internal class HouseDirector
    {
        private IHouseBuilder houseBuilder;

        public HouseDirector(IHouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }

        public void BuildHouse()
        {
            houseBuilder.BuildFloor();
            houseBuilder.BuildCeiling();
            houseBuilder.BuildWall();
            houseBuilder.BuildWindows();
            houseBuilder.BuildDoor();
        }

        public void ChangeBuilder(IHouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }
    }
}
