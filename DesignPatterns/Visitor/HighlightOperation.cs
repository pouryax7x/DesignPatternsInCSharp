using System;

namespace DesignPatterns.Visitor
{
    public class HighlightOperation : Operation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("Highlight heading");

        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("Highlight Anchor");
        }
    }
}