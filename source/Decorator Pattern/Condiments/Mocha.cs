namespace Decorator_Pattern
{
    internal class Mocha:CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription()+", Mocha";
        }

        public override float Cost()
        {
            return _beverage.Cost() + 0.2f;
        }
    }
}