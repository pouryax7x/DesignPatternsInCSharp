namespace DesignPatterns.Bridge
{
    public class RemoteControl
    {
        protected Device device;

        public RemoteControl(Device device)
        {
            this.device = device;
        }

        public void TurnOn()
        {
            device.TurnOn();
        }
        public void TurnOff()
        {
            device.TurnOff();
        }

    }
}