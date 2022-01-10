using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class NescafeCoffee : CoffeeTemplate
    {
        protected override void AddCoffeePowder()
        {
            Console.WriteLine("Nescafe Coffee Powder Added");
        }
    }
}
