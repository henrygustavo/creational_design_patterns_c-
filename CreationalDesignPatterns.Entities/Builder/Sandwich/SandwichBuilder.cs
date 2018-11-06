namespace CreationalDesignPatterns.Entities.Builder.Sandwich
{
	public abstract class SandwichBuilder
	{
		protected internal Sandwich sandwich;

		public virtual Sandwich Sandwich
		{
			set
			{
				this.sandwich = value;
			}
			get
			{
				return sandwich;
			}
		}


		public virtual void CreateNewSandwich()
		{
			sandwich = new Sandwich();
		}

		public abstract void PrepareBread();

		public abstract void ApplyMeatAndCheese();

		public abstract void ApplyVegetables();

		public abstract void AddCondiments();
	}
}