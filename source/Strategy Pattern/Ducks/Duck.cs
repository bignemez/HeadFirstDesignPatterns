using System;

namespace HeadFirstDesignPatterns.StrategyPattern
{
    public abstract class Duck
    {
        protected          IFlyBehavior   _flyBehavior;
        protected          IQuackBehavior _quackBehavior;
        private readonly string         _name;

        protected Duck(string name)
        {
            _name = name;
        }

        public string Name => _name;

        public void PerformQuack()
        {
            _quackBehavior.DoQuack();
        }

        public  void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("I do swim!");
        }

        public virtual void Display()
        {
            Console.WriteLine($"I am {Name}");
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }
    }
}