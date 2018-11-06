namespace CreationalDesignPatterns.Entities.AbstractFactory.Pizza
{
	public class NYPizzaStore : PizzaStore
	{

		protected internal override Pizza CreatePizza(string item)
		{
			Pizza pizza = null;
			PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

			if (item.Equals("cheese"))
			{

				pizza = new CheesePizza(ingredientFactory);
				pizza.Name = "New York Style Cheese Pizza";

			}
			else if (item.Equals("veggie"))
			{

				pizza = new VeggiePizza(ingredientFactory);
				pizza.Name = "New York Style Veggie Pizza";

			}
			else if (item.Equals("clam"))
			{

				pizza = new ClamPizza(ingredientFactory);
				pizza.Name = "New York Style Clam Pizza";

			}
			else if (item.Equals("pepperoni"))
			{

				pizza = new PepperoniPizza(ingredientFactory);
				pizza.Name = "New York Style Pepperoni Pizza";

			}
			return pizza;
		}
	}
}