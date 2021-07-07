using System;

namespace HeadFirstDesignPatterns.StrategyPattern
{
    public class Squeak:IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Squeak! Squeak!");
        }
    }
}