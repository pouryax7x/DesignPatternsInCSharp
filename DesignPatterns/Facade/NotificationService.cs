namespace DesignPatterns.Facade
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            var server2 = new NotificationServer();
            var connection = server2.Connect("IP");
            var authToken = server2.Authenticate("appID", "Key");
            server2.Send(authToken, new Message(message), target);
            connection.Disconnect();
        }
    }
}