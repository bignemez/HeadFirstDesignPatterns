namespace Decorator_Pattern
{
    public abstract class Beverage
    {
        public string Description;

        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract float Cost();
    }
}