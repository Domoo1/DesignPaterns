using free.src.DesignPatterns.Behavioral.Template.StrategyPattern;

var tea = new Tea();
var coffe = new Coffee();

var beverageMaker = new BeverageMaker(tea);
beverageMaker.MakeBeverage();