namespace free.src.DesignPatterns.Behavioral.Command.RemoteControl;

public class TurnOffCommand : ICommand
{
    private Light _light;

        public TurnOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
}