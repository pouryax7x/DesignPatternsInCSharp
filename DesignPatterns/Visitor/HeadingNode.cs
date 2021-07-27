using System;

namespace DesignPatterns.Visitor
{
    public class HeadingNode:HtmlNode
    {
        public void Execute(Operation operation)
        {
            operation.Apply(this);
        }
    }
}