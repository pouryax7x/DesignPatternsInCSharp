using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class SelectionTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("SelectionTool Mouse Down");
        }

        public void MouseUp()
        {
            Console.WriteLine("SelectionTool Mouse Up");
        }
    }
}
