namespace free.src.DesignPatterns.Behavioral.Strategy;

    public class OverlayNone : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Not applying an overlay");
        }
    }
