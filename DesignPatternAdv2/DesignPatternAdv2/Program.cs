using System;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nescafe Coffee Preparation:");
            var coffee = new NescafeCoffee();
            coffee.PrepareCoffee();

            Console.WriteLine();

            Console.WriteLine("Bru Coffee Preparation:");
            var coffee2 = new BruCoffee();
            coffee2.PrepareCoffee();

            Console.ReadLine();
        }
    }
}
