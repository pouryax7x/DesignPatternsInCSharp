using System;

namespace DesignPatterns.Proxy
{
    

    public class RealEbook : Ebook
    {
        private string _fileName;

        public RealEbook(string fileName)
        {
            this._fileName = fileName;
            Load();
        }

        public string FileName
        {
            get => _fileName;
        }

        private void Load()
        {
            Console.WriteLine("loading Ebook " + FileName);
        }

        public void Show()
        {
            Console.WriteLine("Showing Ebook " + FileName);
        }

    }
}