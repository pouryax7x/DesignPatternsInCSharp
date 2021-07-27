namespace DesignPatterns.Command.Editor
{
    public interface UndoableCommand : Command
    {
        void Unexecute();
    }
}