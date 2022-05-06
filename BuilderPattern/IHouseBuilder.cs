namespace BuilderPattern
{
    public interface IHouseBuilder
    {
        void BuildFloor();
        void BuildCeiling();
        void BuildWall();
        void BuildWindows();
        void BuildDoor();
    }
}
