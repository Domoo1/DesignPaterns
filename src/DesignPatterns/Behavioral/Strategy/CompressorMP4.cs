namespace free.src.DesignPatterns.Behavioral.Strategy;

    public class CompressorMP4 : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing video using MP4");
        }
    }
