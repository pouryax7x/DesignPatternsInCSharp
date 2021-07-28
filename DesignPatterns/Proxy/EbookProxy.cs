namespace DesignPatterns.Proxy
{
    public class EbookProxy : Ebook
    {
        private string fileName;
        private RealEbook ebook;
        public EbookProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public string FileName { get; }
        public void Show()
        {
            if (ebook == null)
            {
                ebook = new RealEbook(fileName);
            }
            ebook.Show();
        }
    }
}