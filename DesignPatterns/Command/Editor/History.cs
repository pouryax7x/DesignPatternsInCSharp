using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace DesignPatterns.Command.Editor
{
    public class History
    {
        private List<UndoableCommand> _commands = new List<UndoableCommand>();

        public void Push(UndoableCommand command)
        {
            _commands.Add(command);
        }

        public UndoableCommand Pop()
        {
            var lastIndex = _commands.Count - 1;
            var lastState = _commands[lastIndex];
            _commands.Remove(lastState);
            return lastState;
        }

        public int Size()
        {
            return _commands.Count;
        }
    }
}