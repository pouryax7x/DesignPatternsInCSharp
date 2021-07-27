using System;

namespace DesignPatterns.Facade
{
    public class NotificationServer
    {
        //connect => connection
        //authenticate ( appid , key) => authToken
        //send(authToken , message , target)
        //conn.disconnect

        public Connection Connect(string ipAdress)
        {
            return new Connection();
        }

        public AuthToken Authenticate(string appId , string key)
        {
            return new AuthToken();
        }

        public void Send(AuthToken authToken, Message message, string target)
        {
            Console.WriteLine("Sending A message");
        }
    }
}