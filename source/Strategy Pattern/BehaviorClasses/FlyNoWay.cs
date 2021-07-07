using System;

namespace HeadFirstDesignPatterns.StrategyPattern
{
    public class FlyNoWay:IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I cant fly (((");
        }
    }
}