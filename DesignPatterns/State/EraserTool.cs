using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class EraserTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("EaserTool Mouse Down");
        }

        public void MouseUp()
        {
            Console.WriteLine("EaserTool Mouse up");
        }
    }
}
