namespace Decorator_Pattern
{
    class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() +", Milk";
        }

        public override float Cost()
        {
            return _beverage.Cost() + 0.1f;
        }
    }
}