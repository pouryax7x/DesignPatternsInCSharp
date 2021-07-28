namespace DesignPatterns.Bridge
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public  void SetChannel(int number)
        {
            device.SetChannel(number);
        }

        public AdvancedRemoteControl(Device device) : base(device)
        {
        }
    }
}