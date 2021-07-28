namespace DesignPatterns.Bridge
{
    public interface Device
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int number);
    }
}