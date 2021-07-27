namespace DesignPatterns.Command.FrameWork
{
    public class Button
    {
        private string _label;
        private Command _command;

        public Button(Command command)
        {
            _command = command;
        }

        public string Label => _label;

        public void Click()
        {
            _command.Execute();
        }

        
    }
}