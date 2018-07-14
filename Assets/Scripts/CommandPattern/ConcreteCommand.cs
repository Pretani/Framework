/// <summary>
/// Concrete Command used as an interface to execute an operation
/// </summary>
namespace DesignPatterns.Structural.Command
{
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) :
            base(receiver)
        {
        }

        public override void Execute()
        {
            _receiver.DoAction();
        }
    }
}
