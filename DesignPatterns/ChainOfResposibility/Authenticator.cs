using System;

namespace DesignPatterns.ChainOfResposibility
{
    public class Authenticator : Handler
    {

        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            var isValid = (request.Password == "1234" && request.Username == "admin");
            Console.WriteLine("auth");
            return !isValid;
        }
    }
}