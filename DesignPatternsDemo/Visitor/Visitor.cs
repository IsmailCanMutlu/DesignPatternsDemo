namespace DesignPatternsDemo.Visitor
{
    // Visitor Interface
    public interface IVisitor
    {
        void Visit(ElementA elementA);
        void Visit(ElementB elementB);
    }

    // Concrete Visitor
    public class ConcreteVisitor : IVisitor
    {
        public void Visit(ElementA elementA)
        {
            Console.WriteLine("Visited ElementA");
        }

        public void Visit(ElementB elementB)
        {
            Console.WriteLine("Visited ElementB");
        }
    }

    // Element Interface
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

    // Concrete Element A
    public class ElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    // Concrete Element B
    public class ElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    // Object Structure
    public class ObjectStructure
    {
        private readonly List<IElement> _elements = new List<IElement>();

        public void Attach(IElement element)
        {
            _elements.Add(element);
        }

        public void Detach(IElement element)
        {
            _elements.Remove(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }

    // Usage
    public static class Program
    {
        public static void Main()
        {
            ObjectStructure objectStructure = new ObjectStructure();

            objectStructure.Attach(new ElementA());
            objectStructure.Attach(new ElementB());

            ConcreteVisitor visitor = new ConcreteVisitor();
            objectStructure.Accept(visitor);
        }
    }
}