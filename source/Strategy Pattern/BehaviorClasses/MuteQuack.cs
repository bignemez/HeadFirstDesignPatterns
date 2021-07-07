using System;

namespace HeadFirstDesignPatterns.StrategyPattern
{
    class MuteQuack:IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("I cant quack (((");
        }
    }
}