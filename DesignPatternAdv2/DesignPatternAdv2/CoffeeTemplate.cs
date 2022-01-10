using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public abstract class CoffeeTemplate
    {
        public void PrepareCoffee()
        {
            BoilWater();
            AddMilk();
            AddSugar();
            AddCoffeePowder();
            Console.WriteLine(this.GetType().Name + " is Ready");
        }

        public void BoilWater() {
            Console.WriteLine("Water Boiled.");
        }

        public void AddMilk() {
            Console.WriteLine("Milk Added");
        }

        public void AddSugar() {
            Console.WriteLine("Sugar Added");
        }

        protected abstract void AddCoffeePowder();
    }
}
