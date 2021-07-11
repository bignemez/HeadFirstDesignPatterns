namespace Decorator_Pattern
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend";
        }

        public override float Cost()
        {
            return 0.89f;
        }
    }
}