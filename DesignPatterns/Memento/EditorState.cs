using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class EditorState
    {
        private readonly string _content;

        public EditorState(string content)
        {
            _content = content;
        }

        public string Content => _content;
    }
}
