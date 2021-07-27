namespace DesignPatterns.ChainOfResposibility
{
    public abstract class Handler
    {
        private Handler next;

        public Handler(Handler next)
        {
            this.next = next;
        }

        public abstract bool DoHandle(HttpRequest request);

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
                return;
            if (next != null)
                next.Handle(request);
        }
    }
}