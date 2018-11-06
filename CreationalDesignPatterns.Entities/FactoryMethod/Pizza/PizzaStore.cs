using System;
using System.Diagnostics;

namespace CreationalDesignPatterns.Entities.FactoryMethod.Pizza
{
	public abstract class PizzaStore
	{

		internal abstract Pizza CreatePizza(string item);

		public  Pizza OrderPizza(string type)
		{
			Pizza pizza = CreatePizza(type);
			Debug.WriteLine("--- Making a " + pizza.Name + " ---");
			pizza.Prepare();
			pizza.Bake();
			pizza.Cut();
			pizza.Box();
			return pizza;
		}
	}
}