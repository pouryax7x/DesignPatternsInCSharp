namespace DesignPatterns.Mediator
{
    public class ListBox : UIControl
    {
        private string _selection;

        public string Selection
        {
            get => _selection;
            set
            {
                _selection = value;
                _owner.Changed(this);
            }
        }

        public ListBox(DialogBox owner) : base(owner)
        {
        }
    }
}