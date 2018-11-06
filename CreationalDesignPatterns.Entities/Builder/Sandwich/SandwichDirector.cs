namespace CreationalDesignPatterns.Entities.Builder.Sandwich
{
	public class SandwichDirector
	{
		private SandwichBuilder builder;

		public SandwichDirector(SandwichBuilder builder)
		{
			this.builder = builder;
		}

		public virtual void BuildSandwich()
		{
			builder.CreateNewSandwich();
			builder.PrepareBread();
			builder.ApplyMeatAndCheese();
			builder.ApplyVegetables();
			builder.AddCondiments();
		}

		public virtual Sandwich Sandwhich
		{
			get
			{
				return builder.Sandwich;
			}
		}
	}
}