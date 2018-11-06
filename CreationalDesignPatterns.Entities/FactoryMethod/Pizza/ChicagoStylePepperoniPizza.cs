using System;
using System.Diagnostics;

namespace CreationalDesignPatterns.Entities.FactoryMethod.Pizza
{
	public class ChicagoStylePepperoniPizza : Pizza
	{
		public ChicagoStylePepperoniPizza()
		{
			name = "Chicago Style Pepperoni Pizza";
			dough = "Extra Thick Crust Dough";
			sauce = "Plum Tomato Sauce";

			toppings.Add("Shredded Mozzarella Cheese");
			toppings.Add("Black Olives");
			toppings.Add("Spinach");
			toppings.Add("Eggplant");
			toppings.Add("Sliced Pepperoni");
		}

		internal override void Cut()
		{
			Debug.WriteLine("Cutting the pizza into square slices");
		}
	}

}