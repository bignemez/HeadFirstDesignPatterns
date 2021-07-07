namespace HeadFirstDesignPatterns.StrategyPattern
{
    public class ModelDuck:Duck
    {
        public ModelDuck(string name) : base(name)
        {
            _flyBehavior   = new FlyNoWay();
            _quackBehavior = new Quack();
        }
        
    }

   
}