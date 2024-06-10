namespace DesignPatternsDemo.AbstractFactory
{
    // Abstract Product A
    public interface IButton
    {
        void Paint();
    }

    // Abstract Product B
    public interface ICheckbox
    {
        void Paint();
    }

    // Concrete Product A1
    public class WinButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Rendering a button in Windows style.");
        }
    }

    // Concrete Product B1
    public class WinCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Rendering a checkbox in Windows style.");
        }
    }

    // Concrete Product A2
    public class MacButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Rendering a button in Mac style.");
        }
    }

    // Concrete Product B2
    public class MacCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Rendering a checkbox in Mac style.");
        }
    }

    // Abstract Factory
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }

    // Concrete Factory 1
    public class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }

    // Concrete Factory 2
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }

    // Client
    public class Application
    {
        private readonly IButton _button;
        private readonly ICheckbox _checkbox;

        public Application(IGUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();
        }

        public void Paint()
        {
            _button.Paint();
            _checkbox.Paint();
        }
    }

    // Usage
    public static class Program
    {
        public static void Main()
        {
            IGUIFactory factory = new WinFactory();
            Application app = new Application(factory);
            app.Paint();

            factory = new MacFactory();
            app = new Application(factory);
            app.Paint();
        }
    }
}
