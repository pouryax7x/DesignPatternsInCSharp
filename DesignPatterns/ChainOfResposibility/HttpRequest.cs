namespace DesignPatterns.ChainOfResposibility
{
    public class HttpRequest
    {
        private string _username;
        private string _password;

        public HttpRequest(string username, string password)
        {
            this._username = username;
            this._password = password;
        }

        public string Username => _username;

        public string Password => _password;
    }
}