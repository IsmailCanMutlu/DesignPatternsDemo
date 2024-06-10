namespace DesignPatternsDemo.Bridge
{
    // Abstraction
    public abstract class RemoteControl
    {
        protected IDevice device;

        protected RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
    }

    // Refined Abstraction
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device) { }

        public void SetChannel(int channel)
        {
            device.SetChannel(channel);
        }

        public override void TurnOn()
        {
            device.TurnOn();
        }

        public override void TurnOff()
        {
            device.TurnOff();
        }
    }

    // Implementor
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int channel);
    }

    // Concrete Implementor 1
    public class TV : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Turning on the TV.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off the TV.");
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"Setting TV channel to {channel}.");
        }
    }

    // Concrete Implementor 2
    public class Radio : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Turning on the radio.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off the radio.");
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"Setting radio frequency to {channel}.");
        }
    }

    // Usage
    public static class Program
    {
        public static void Main()
        {
            IDevice tv = new TV();
            RemoteControl remoteControl = new AdvancedRemoteControl(tv);
            remoteControl.TurnOn();
            ((AdvancedRemoteControl)remoteControl).SetChannel(10);
            remoteControl.TurnOff();

            IDevice radio = new Radio();
            remoteControl = new AdvancedRemoteControl(radio);
            remoteControl.TurnOn();
            ((AdvancedRemoteControl)remoteControl).SetChannel(95);
            remoteControl.TurnOff();
        }
    }
}
