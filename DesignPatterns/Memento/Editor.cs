using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
{
    public class Editor
    {
        private string _content;

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        public void Restore(EditorState state)
        {
            Content = state.Content;
        }
        public string Content
        {
            get => _content;
            set => _content = value;
        }
    }
}
