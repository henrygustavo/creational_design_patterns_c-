using System.Diagnostics;

namespace CreationalDesignPatterns.Entities.AbstractFactory.Pizza
{
	public class PepperoniPizza : Pizza
	{
		internal PizzaIngredientFactory ingredientFactory;

		public PepperoniPizza(PizzaIngredientFactory ingredientFactory)
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
			pepperoni = ingredientFactory.CreatePepperoni();
		}
	}

}