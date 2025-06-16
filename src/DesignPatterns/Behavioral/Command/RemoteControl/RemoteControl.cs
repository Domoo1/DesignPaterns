namespace free.src.DesignPatterns.Behavioral.Command.RemoteControl;

public class RemoteControl
{
    private ICommand _command;

        public RemoteControl(ICommand command)
        {
            _command = command;
        }

        // Allow ability to swap commands at runtime
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        } 
}