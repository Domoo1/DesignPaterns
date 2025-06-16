namespace free.src.DesignPatterns.Behavioral.Template.TemplateMethod;

public class Camomile : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Brewing camomile for 3 minutes");
    }
}