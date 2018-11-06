using System;
using System.Diagnostics;

namespace CreationalDesignPatterns.Entities.FactoryMethod.Pizza
{
	public class ChicagoStyleCheesePizza : Pizza
	{

		public ChicagoStyleCheesePizza()
		{
			name = "Chicago Style Deep Dish Cheese Pizza";
			dough = "Extra Thick Crust Dough";
			sauce = "Plum Tomato Sauce";

			toppings.Add("Shredded Mozzarella Cheese");
		}

		internal override void Cut()
		{
			Debug.WriteLine("Cutting the pizza into square slices");
		}
	}

}