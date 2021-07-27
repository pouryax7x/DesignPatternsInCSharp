using System.Collections.Generic;

namespace DesignPatterns.Command
{
    public class CompositeCommand:FrameWork.Command
    {
        private List<FrameWork.Command> commands = new List<FrameWork.Command>();

        public void Add(FrameWork.Command command)
        {
            commands.Add(command);
        }
        public void Execute()
        {
            foreach (var command in commands)
            {
                command.Execute();
            } 
        }
    }
}