using System.Diagnostics;

namespace CreationalDesignPatterns.Entities.AbstractFactory.Pizza
{
	public class CheesePizza : Pizza
	{
		internal PizzaIngredientFactory ingredientFactory;

		public CheesePizza(PizzaIngredientFactory ingredientFactory)
		{
			this.ingredientFactory = ingredientFactory;
		}

		internal override void Prepare()
		{
			Debug.WriteLine("Preparing " + name);
			dough = ingredientFactory.CreateDough();
			sauce = ingredientFactory.CreateSauce();
			cheese = ingredientFactory.CreateCheese();
		}
	}
}