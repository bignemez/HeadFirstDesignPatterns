namespace Decorator_Pattern
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override float Cost()
        {
            return 1.99f;
        }
    }
}