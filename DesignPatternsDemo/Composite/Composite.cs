namespace DesignPatternsDemo.Composite
{
    // Component
    public abstract class Graphic
    {
        public abstract void Draw();
    }

    // Leaf
    public class Circle : Graphic
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }
    }

    // Composite
    public class CompositeGraphic : Graphic
    {
        private readonly List<Graphic> _graphics = new List<Graphic>();

        public void Add(Graphic graphic)
        {
            _graphics.Add(graphic);
        }

        public void Remove(Graphic graphic)
        {
            _graphics.Remove(graphic);
        }

        public override void Draw()
        {
            foreach (var graphic in _graphics)
            {
                graphic.Draw();
            }
        }
    }

    // Usage
    public static class Program
    {
        public static void Main()
        {
            Circle circle1 = new Circle();
            Circle circle2 = new Circle();

            CompositeGraphic composite = new CompositeGraphic();
            composite.Add(circle1);
            composite.Add(circle2);

            composite.Draw();
        }
    }
}