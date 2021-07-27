using System;

namespace DesignPatterns.Visitor
{
    public class AnchorNode : HtmlNode
    {
        public void Execute(Operation operation)
        {
            operation.Apply(this);
        }
    }
}