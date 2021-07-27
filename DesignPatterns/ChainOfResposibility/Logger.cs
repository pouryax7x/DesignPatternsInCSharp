using System;

namespace DesignPatterns.ChainOfResposibility
{
    public class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Log");
            return false;
        }
    }
}