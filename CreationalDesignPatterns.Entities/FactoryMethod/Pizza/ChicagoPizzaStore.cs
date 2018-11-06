namespace CreationalDesignPatterns.Entities.FactoryMethod.Pizza
{
	public class ChicagoPizzaStore : PizzaStore
	{

		internal override Pizza CreatePizza(string item)
		{
				if (item.Equals("cheese"))
				{
						return new ChicagoStyleCheesePizza();
				}
				else if (item.Equals("veggie"))
				{
						return new ChicagoStyleVeggiePizza();
				}
				else if (item.Equals("clam"))
				{
						return new ChicagoStyleClamPizza();
				}
				else if (item.Equals("pepperoni"))
				{
						return new ChicagoStylePepperoniPizza();
				}
				else
				{
					return null;
				}
		}
	}
}