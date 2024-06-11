namespace DesignPatternsDemo.Decorator
{
    // Component
    public interface ICar
    {
        string GetDescription();
        double GetCost();
    }

    // Concrete Component
    public class Car : ICar
    {
        public string GetDescription()
        {
            return "Basic Car";
        }

        public double GetCost()
        {
            return 20000;
        }
    }

    // Decorator
    public abstract class CarDecorator : ICar
    {
        protected ICar _car;

        protected CarDecorator(ICar car)
        {
            _car = car;
        }

        public virtual string GetDescription()
        {
            return _car.GetDescription();
        }

        public virtual double GetCost()
        {
            return _car.GetCost();
        }
    }

    // Concrete Decorator 1
    public class LuxuryCar : CarDecorator
    {
        public LuxuryCar(ICar car) : base(car) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Luxury Package";
        }

        public override double GetCost()
        {
            return base.GetCost() + 10000;
        }
    }

    // Concrete Decorator 2
    public class SportsCar : CarDecorator
    {
        public SportsCar(ICar car) : base(car) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Sports Package";
        }

        public override double GetCost()
        {
            return base.GetCost() + 15000;
        }
    }

    // Usage
    public static class Program
    {
        public static void Main()
        {
            ICar basicCar = new Car();
            Console.WriteLine($"{basicCar.GetDescription()} costs {basicCar.GetCost()}");

            ICar luxuryCar = new LuxuryCar(basicCar);
            Console.WriteLine($"{luxuryCar.GetDescription()} costs {luxuryCar.GetCost()}");

            ICar sportsCar = new SportsCar(basicCar);
            Console.WriteLine($"{sportsCar.GetDescription()} costs {sportsCar.GetCost()}");

            ICar luxurySportsCar = new SportsCar(new LuxuryCar(basicCar));
            Console.WriteLine($"{luxurySportsCar.GetDescription()} costs {luxurySportsCar.GetCost()}");
        }
    }
}
