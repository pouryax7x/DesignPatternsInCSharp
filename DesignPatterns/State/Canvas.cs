using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Canvas
    {
        private Tool currenctTool;

        public void MouseDown()
        {
            currenctTool.MouseDown();
        }

        public void MouseUp()
        {
            currenctTool.MouseUp();
        }
        public Tool CurrenctTool
        {
            get => currenctTool;
            set => currenctTool = value;
        }
    }
}
