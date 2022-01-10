using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class BruCoffee : CoffeeTemplate
    {
        protected override void AddCoffeePowder()
        {
            Console.WriteLine("Bru Coffee Powder Added");
        }
    }
}
