namespace free.src.DesignPatterns.Behavioral.Command.RemoteControl;

public class Light
{
   public void TurnOn()
        {
            System.Console.WriteLine("Light is on");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Light is off");
        }

        public void Dim()
        {
            System.Console.WriteLine("Light is dim");
        } 
}