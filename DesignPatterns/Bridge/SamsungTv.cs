using System;

namespace DesignPatterns.Bridge
{
    public class SamsungTV : Device
    {
        public void TurnOn()
        {
            Console.WriteLine("Samsung turn on");
        }

        public void TurnOff()
        {
            Console.WriteLine("samsung turn on");
        }

        public void SetChannel(int number)
        {
            Console.WriteLine("samsung set channel");
        }
    }
}