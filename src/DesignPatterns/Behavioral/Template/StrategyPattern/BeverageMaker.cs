using System.Diagnostics.Contracts;

namespace free.src.DesignPatterns.Behavioral.Template.StrategyPattern;

public class BeverageMaker
{
    private Beverage _beverage;

    public BeverageMaker(Beverage beverage) {
        _beverage = beverage;
    }

    public void SetBeverage(Beverage beverage) {
        _beverage = beverage;
    }

    public void MakeBeverage() {
        BoilWater();
        PourIntoCup();

        // Unique Operations
        _beverage.Prepare();
    }

    public void BoilWater() {
        System.Console.WriteLine("Boiling Water");
    }

    public void PourIntoCup() {
        System.Console.WriteLine("Pouring boiled water into cup");
    }
}
