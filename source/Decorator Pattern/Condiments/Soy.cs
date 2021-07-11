namespace Decorator_Pattern
{
    internal class Soy:CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription()+", Soy";
        }

        public override float Cost()
        {
            return _beverage.Cost() + 0.15f;
        }
    }
}