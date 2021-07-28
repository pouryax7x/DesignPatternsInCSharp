using System.Collections.Generic;

namespace DesignPatterns.Proxy
{
    public class Library
    {
        private Dictionary<string, Ebook> ebooks = new Dictionary<string, Ebook>();
        public void Add(Ebook ebook)
        {
            ebooks.Add(ebook.FileName, ebook);
        }

        public void OpenEbook(string filename)
        {
            ebooks[filename]?.Show();
        }
    }
}