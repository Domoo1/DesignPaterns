namespace free.src.DesignPatterns.Behavioral.Strategy;

    public class OverlayBlur : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying blur overlay");
        }
    }
