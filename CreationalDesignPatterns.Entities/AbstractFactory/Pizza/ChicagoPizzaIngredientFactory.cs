namespace CreationalDesignPatterns.Entities.AbstractFactory.Pizza
{
	public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
	{

		public virtual Dough CreateDough()
		{
			return new ThickCrustDough();
		}

		public virtual Sauce CreateSauce()
		{
			return new PlumTomatoSauce();
		}

		public virtual Cheese CreateCheese()
		{
			return new MozzarellaCheese();
		}

		public virtual Veggies[] CreateVeggies()
		{
			Veggies[] veggies = new Veggies[]
			{
				new BlackOlives(),
				new Spinach(),
				new Eggplant()
			};
			return veggies;
		}

		public virtual Pepperoni CreatePepperoni()
		{
			return new SlicedPepperoni();
		}

		public virtual Clams CreateClam()
		{
			return new FrozenClams();
		}
	}
}