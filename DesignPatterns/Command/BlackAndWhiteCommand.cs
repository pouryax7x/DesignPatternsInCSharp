using System;

namespace DesignPatterns.Command
{
    public class BlackAndWhiteCommand : FrameWork.Command
    {
        public void Execute()
        {
            Console.WriteLine("Black And Wite");
        }
    }
}