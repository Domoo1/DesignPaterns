using System.Runtime.CompilerServices;

namespace free.src.DesignPatterns.Behavioral.Template.TemplateMethod;

public class Tea : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Brewing tea for 3 minutes");
    }

    protected override void AddCondiments()
    {
        if (CustomerWantsCondiments())
            System.Console.WriteLine("Adding lemon to tea");
    }

    private bool CustomerWantsCondiments()
    {
        Console.WriteLine("Would you like lemon with your tea? (y/n)");
        string input = Console.ReadLine();
        return input.ToLower() == "y";
    }
}