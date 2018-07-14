/// <summary>
/// Invoker class used to tell the Command to carry out the request
/// </summary>
namespace DesignPatterns.Structural.Command
{
    public class Invoker
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}
