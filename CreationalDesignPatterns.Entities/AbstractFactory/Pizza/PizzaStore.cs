using System.Diagnostics;

namespace CreationalDesignPatterns.Entities.AbstractFactory.Pizza
{
	public abstract class PizzaStore
	{

		protected internal abstract Pizza CreatePizza(string item);

		public virtual Pizza OrderPizza(string type)
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