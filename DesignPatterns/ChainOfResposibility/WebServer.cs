namespace DesignPatterns.ChainOfResposibility
{
    public class WebServer
    {
        private Handler handler;

        public WebServer(Handler handler)
        {
            this.handler = handler;
        }

        public void Handle(HttpRequest request)
        {
            handler.Handle(request);
            //authentication

            //logging

            //compression
        }
    }
}