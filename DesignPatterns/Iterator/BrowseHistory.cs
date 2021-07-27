using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class BrowseHistory
    {
        private List<string> urls = new List<string>();

        public void Push(string url)
        {
            urls.Add(url);
        }

        public string Pop()
        {
            var lastIndex = urls.Count - 1;
            var lastState = urls[lastIndex];
            urls.Remove(lastState);
            return lastState;
        }

        public Iterator<string> CreateIterator()
        {
            return new ListIterator(this);

        }

        private class ListIterator : Iterator<string>
        {
            private readonly BrowseHistory _history;
            private int _index;

            public ListIterator(BrowseHistory history)
            {
                _history = history;
            }

            public bool HasNext()
            {
                return _index < _history.urls.Count;
            }

            public string Current()
            {
                return _history.urls[_index];
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}