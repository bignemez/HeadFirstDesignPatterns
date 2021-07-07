using System;


namespace HeadFirstDesignPatterns.StrategyPattern
{
    public class FlyWithWings:IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I do fly!");
        }
    }
}