namespace DesignPatternsDemo.Builder
{
    // Product
    public class House
    {
        public string Walls { get; set; }
        public string Roof { get; set; }
        public string Windows { get; set; }

        public override string ToString()
        {
            return $"House with {Walls}, {Roof}, and {Windows}";
        }
    }

    // Abstract Builder
    public interface IHouseBuilder
    {
        void BuildWalls();
        void BuildRoof();
        void BuildWindows();
        House GetHouse();
    }

    // Concrete Builder
    public class ConcreteHouseBuilder : IHouseBuilder
    {
        private House _house = new House();

        public void BuildWalls()
        {
            _house.Walls = "Concrete Walls";
        }

        public void BuildRoof()
        {
            _house.Roof = "Concrete Roof";
        }

        public void BuildWindows()
        {
            _house.Windows = "Glass Windows";
        }

        public House GetHouse()
        {
            return _house;
        }
    }

    // Director
    public class HouseDirector
    {
        private readonly IHouseBuilder _builder;

        public HouseDirector(IHouseBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructHouse()
        {
            _builder.BuildWalls();
            _builder.BuildRoof();
            _builder.BuildWindows();
        }
    }

    // Usage
    public static class Program
    {
        public static void Main()
        {
            IHouseBuilder builder = new ConcreteHouseBuilder();
            HouseDirector director = new HouseDirector(builder);
            director.ConstructHouse();

            House house = builder.GetHouse();
            Console.WriteLine(house.ToString());
        }
    }
}