namespace CreationalDesignPatterns.Entities.FactoryMethod.Pizza
{
	public class NYPizzaStore : PizzaStore
	{

		internal override Pizza CreatePizza(string item)
		{
			if (item.Equals("cheese"))
			{
				return new NYStyleCheesePizza();
			}
			else if (item.Equals("veggie"))
			{
				return new NYStyleVeggiePizza();
			}
			else if (item.Equals("clam"))
			{
				return new NYStyleClamPizza();
			}
			else if (item.Equals("pepperoni"))
			{
				return new NYStylePepperoniPizza();
			}
			else
			{
				return null;
			}
		}
	}
}