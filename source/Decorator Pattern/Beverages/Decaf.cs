namespace Decorator_Pattern
{
    class Decaf:Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }

        public override float Cost()
        {
            return 1.05f;
        }
    }
}