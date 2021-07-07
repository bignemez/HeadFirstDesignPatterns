using System;

namespace HeadFirstDesignPatterns.StrategyPattern
{
    public class Quack:IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Quack! Quack!");
        }
    }
}