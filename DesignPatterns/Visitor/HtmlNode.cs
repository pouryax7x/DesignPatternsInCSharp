namespace DesignPatterns.Visitor
{
    public interface HtmlNode
    {
        void Execute(Operation operation);
    }
}