using System;

namespace HeadFirstDesignPatterns.StrategyPattern
{
    public class FlyRocketPowered:IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}