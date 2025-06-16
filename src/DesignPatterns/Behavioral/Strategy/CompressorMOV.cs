namespace free.src.DesignPatterns.Behavioral.Strategy;

public class CompressorMOV : ICompressor
{
    public void Compress()
    {
        System.Console.WriteLine("Compressing video using MOV");
    }
}
