using System.ComponentModel;

namespace free.src.DesignPatterns.Behavioral.Template.TemplateMethod;

public abstract class Beverage
{
    public void Prepare()
    {
        BoilWater();
        PourIntoCup();
        Brew();
        AddCondiments();
    }

    private void BoilWater()
    {
        Console.WriteLine("Boiling Water");
    }

    private void PourIntoCup()
    {
        Console.WriteLine("Pouring beverage into cup");
    }

    protected abstract void Brew();

    protected virtual void AddCondiments() { }
    
}