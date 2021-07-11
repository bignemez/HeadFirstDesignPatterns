using System;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Beverage darkRoast = new DarkRoast();
            Console.WriteLine($"Bestellt: {darkRoast.GetDescription()}\n Bezahlt: {darkRoast.Cost()}");
            Beverage espresso = new Espresso();
            espresso = new Mocha(espresso);
            espresso = new Mocha(espresso);
            espresso = new Whip(espresso);
            Console.WriteLine($"Bestellt: {espresso.GetDescription()}\n Bezahlt: {espresso.Cost()}");
            
            
        }
    }
}