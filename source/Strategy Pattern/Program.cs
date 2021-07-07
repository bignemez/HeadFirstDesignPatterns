using System;

namespace HeadFirstDesignPatterns.StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var mallardDuck = new MallardDuck("Mallard");
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();
            mallardDuck.Swim();
            mallardDuck.Display();
            Console.WriteLine("############################");
            var model = new ModelDuck("Model");
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();

        }
    }
}