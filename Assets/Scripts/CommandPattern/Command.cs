/// <summary>
/// Base Command class to declare/define commonly used members and methods
/// </summary>
namespace DesignPatterns.Structural.Command
{
    public abstract class Command
    {
        protected Receiver _receiver;

        public Command(Receiver receiver)
        {
            _receiver = receiver;
        }

        public abstract void Execute();
    }
}
