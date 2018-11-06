using System.Diagnostics;

namespace CreationalDesignPatterns.Entities.AbstractFactory.Pizza
{
	public class VeggiePizza : Pizza
	{
		internal PizzaIngredientFactory ingredientFactory;

		public VeggiePizza(PizzaIngredientFactory ingredientFactory)
		{
			this.ingredientFactory = ingredientFactory;
		}

		internal override void Prepare()
		{
			Debug.WriteLine("Preparing " + name);
			dough = ingredientFactory.CreateDough();
			sauce = ingredientFactory.CreateSauce();
			cheese = ingredientFactory.CreateCheese();
			veggies = ingredientFactory.CreateVeggies();
		}
	}

}