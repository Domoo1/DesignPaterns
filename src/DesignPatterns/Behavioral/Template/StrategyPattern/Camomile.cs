namespace free.src.DesignPatterns.Behavioral.Template.StrategyPattern;

public class Camomile : Beverage
{
    public void Prepare()
    {
        Brew();
    }

    public void Brew()
    {
        System.Console.WriteLine("Brewing for 3 minutes");
    }
}
