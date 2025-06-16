namespace free.src.DesignPatterns.Behavioral.Strategy;

public class CompressorWebM : ICompressor
{
    public void Compress()
    {
        System.Console.WriteLine("Compressing video using WebM");
    }
}
