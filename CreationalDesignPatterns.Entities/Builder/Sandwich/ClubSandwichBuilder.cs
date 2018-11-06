using System.Collections.Generic;

namespace CreationalDesignPatterns.Entities.Builder.Sandwich
{

	public class ClubSandwichBuilder : SandwichBuilder
	{

		public override void PrepareBread()
		{
			sandwich.BreadType = BreadType.White;
			sandwich.Toasted = true;
		}

		public override void ApplyMeatAndCheese()
		{
			sandwich.CheeseType = CheeseType.Swiss;
			sandwich.MeatType = MeatType.Turkey;
		}

		public override void ApplyVegetables()
		{
			sandwich.Vegetables = new List<string>{"Tomato", "Onion", "Lettuce"};
		}

		public override void AddCondiments()
		{
			sandwich.HasMayo = true;
			sandwich.HasMustard = true;
		}
	}
}