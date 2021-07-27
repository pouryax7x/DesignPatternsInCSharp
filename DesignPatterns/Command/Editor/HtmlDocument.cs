namespace DesignPatterns.Command.Editor
{
    public class HtmlDocument
    {
        private string _content;

        public void MakeBold()
        {
            _content = "<b>" + _content + "</b>";
        }
        public string Content
        {
            get => _content;
            set => _content = value;
        }
    }
}