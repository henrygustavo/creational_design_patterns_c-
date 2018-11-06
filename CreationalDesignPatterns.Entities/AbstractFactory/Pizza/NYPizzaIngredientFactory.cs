namespace CreationalDesignPatterns.Entities.AbstractFactory.Pizza
{
	public class NYPizzaIngredientFactory : PizzaIngredientFactory
	{

		public virtual Dough CreateDough()
		{
			return new ThinCrustDough();
		}

		public virtual Sauce CreateSauce()
		{
			return new MarinaraSauce();
		}

		public virtual Cheese CreateCheese()
		{
			return new ReggianoCheese();
		}

		public virtual Veggies[] CreateVeggies()
		{
			Veggies[] veggies = new Veggies[]
			{
				new Garlic(),
				new Onion(),
				new Mushroom(),
				new RedPepper()
			};
			return veggies;
		}

		public virtual Pepperoni CreatePepperoni()
		{
			return new SlicedPepperoni();
		}

		public virtual Clams CreateClam()
		{
			return new FreshClams();
		}
	}

}