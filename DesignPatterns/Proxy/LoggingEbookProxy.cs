using System;

namespace DesignPatterns.Proxy
{
    public class LoggingEbookProxy : Ebook
    {
        private string _fileName;
        private RealEbook ebook;

        public LoggingEbookProxy(string fileName)
        {
            this._fileName = fileName;
        }

        public string FileName { get; }
        public void Show()
        {
            if (ebook == null)
            {
                ebook = new RealEbook(_fileName);
            }

            Console.WriteLine("log");
            Console.WriteLine("Auth");
            ebook.Show();
        }
    }
}