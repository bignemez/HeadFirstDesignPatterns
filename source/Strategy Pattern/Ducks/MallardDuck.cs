namespace HeadFirstDesignPatterns.StrategyPattern
{
    public class MallardDuck:Duck
    {
        public MallardDuck(string name) : base(name)
        {
            _quackBehavior = new Quack();
            _flyBehavior   = new FlyWithWings();
        }
        
    }
}