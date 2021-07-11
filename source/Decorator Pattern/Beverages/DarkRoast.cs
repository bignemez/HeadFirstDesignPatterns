namespace Decorator_Pattern
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast";
        }

        public override float Cost()
        {
            return 0.99f;
        }
    }
}