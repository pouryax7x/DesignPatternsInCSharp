using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class PlainTextOperation : Operation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("text - heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("text - anchor");
        }
    }
}
