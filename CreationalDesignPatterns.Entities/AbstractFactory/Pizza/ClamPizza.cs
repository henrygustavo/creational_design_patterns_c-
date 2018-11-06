using System.Diagnostics;

namespace CreationalDesignPatterns.Entities.AbstractFactory.Pizza
{
	public class ClamPizza : Pizza
	{
		internal PizzaIngredientFactory ingredientFactory;

		public ClamPizza(PizzaIngredientFactory ingredientFactory)
		{
			this.ingredientFactory = ingredientFactory;
		}

		internal override void Prepare()
		{
			Debug.WriteLine("Preparing " + name);
			dough = ingredientFactory.CreateDough();
			sauce = ingredientFactory.CreateSauce();
			cheese = ingredientFactory.CreateCheese();
			clam = ingredientFactory.CreateClam();
		}
	}
}