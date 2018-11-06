using System;
using System.Diagnostics;

namespace CreationalDesignPatterns.Entities.FactoryMethod.Pizza
{
	public class ChicagoStyleVeggiePizza : Pizza
	{
		public ChicagoStyleVeggiePizza()
		{
			name = "Chicago Deep Dish Veggie Pizza";
			dough = "Extra Thick Crust Dough";
			sauce = "Plum Tomato Sauce";

			toppings.Add("Shredded Mozzarella Cheese");
			toppings.Add("Black Olives");
			toppings.Add("Spinach");
			toppings.Add("Eggplant");
		}

		internal override void Cut()
		{
			Debug.WriteLine("Cutting the pizza into square slices");
		}
	}

}