using System.Collections.Generic;

namespace DesignPatterns.Visitor
{
    public class HtmlDocument
    {
        private List<HtmlNode> nodes = new List<HtmlNode>();

        public void Add(HtmlNode node)
        {
            nodes.Add(node);
        }

        public void Execute(Operation operation)
        {
            foreach (var htmlNode in nodes)
            {
                htmlNode.Execute(operation);
            }
        }
    }
}