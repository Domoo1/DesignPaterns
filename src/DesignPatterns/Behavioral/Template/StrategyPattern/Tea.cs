namespace free.src.DesignPatterns.Behavioral.Template.StrategyPattern;

public class Tea : Beverage
{
    public void Prepare()
    {
        Brew();
        AddCondiments();
    }

    private void Brew()
    {
        System.Console.WriteLine("Brewing tea for 3 minutes");
    }

    private void AddCondiments()
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