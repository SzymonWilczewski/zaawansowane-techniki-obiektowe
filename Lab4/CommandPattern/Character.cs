using System.Numerics;

namespace CommandPattern
{
    public class Character
    {
        public Vector3 Position { get; set; }
        private readonly MoveCommandHandler commands = new();

        public void Move(ICommand command)
        {
            commands.Handle(command);
        }

        public void ComeBack()
        {
            commands.Undo();
        }

        public void MoveAgain()
        {
            commands.Redo();
        }

        public override string ToString() => $"Current position: {this.Position}";
    }
}
