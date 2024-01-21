using System.Collections.Generic;
using System.Linq;

namespace CommandPattern
{
    public class MoveCommandHandler
    {
        private readonly Stack<ICommand> commands = new Stack<ICommand>();
        private readonly Stack<ICommand> redos = new Stack<ICommand>();

        public void Handle(ICommand command)
        {
            redos.Clear();
            commands.Push(command);
            command.Execute();
        }

        public void Undo()
        {
            if (commands.Any())
            {
                redos.Push(commands.Peek());
                commands.Pop().Undo();
            }
        }

        public void Redo()
        {
            if (redos.Any())
            {
                commands.Push(redos.Peek());
                redos.Pop().Execute();
            }
        }
    }
}
