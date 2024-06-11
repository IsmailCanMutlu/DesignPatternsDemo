namespace DesignPatternsDemo.State
{
    // State Interface
    public interface IState
    {
        void Handle(Context context);
    }

    // Concrete State A
    public class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("State A handling request.");
            context.State = new ConcreteStateB();
        }
    }

    // Concrete State B
    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("State B handling request.");
            context.State = new ConcreteStateA();
        }
    }

    // Context
    public class Context
    {
        private IState _state;

        public Context(IState state)
        {
            State = state;
        }

        public IState State
        {
            get => _state;
            set
            {
                _state = value;
                Console.WriteLine($"State changed to { _state.GetType().Name }");
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }

    // Usage
    public static class Program
    {
        public static void Main()
        {
            Context context = new Context(new ConcreteStateA());

            context.Request();
            context.Request();
            context.Request();
            context.Request();
        }
    }
}