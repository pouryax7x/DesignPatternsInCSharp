using System;

namespace DesignPatterns.Command
{
    public class ResizeCommand : FrameWork.Command

    {
        public void Execute()
        {
            Console.WriteLine("resize");
        }
    }
}