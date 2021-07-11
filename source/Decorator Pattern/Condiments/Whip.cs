namespace Decorator_Pattern
{
    internal class Whip:CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription()+", Whip";
        }

        public override float Cost()
        {
            return _beverage.Cost() + 0.10f;
        }
    }
}