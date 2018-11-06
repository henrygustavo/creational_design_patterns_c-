using System.Collections.Generic;

namespace CreationalDesignPatterns.Entities.Builder.Sandwich
{

	public class MySandwichBuilder : SandwichBuilder
	{

		public override void PrepareBread()
		{

			sandwich.BreadType = BreadType.White;
			sandwich.Toasted = true;
		}

		public override void ApplyMeatAndCheese()
		{
			sandwich.CheeseType = CheeseType.Cheddar;
			sandwich.MeatType = MeatType.Chicken;
		}

		public override void ApplyVegetables()
		{
			sandwich.Vegetables = new List<string> {"Tomato", "Onion"};
		}

		public override void AddCondiments()
		{
			sandwich.HasMayo = false;
			sandwich.HasMustard = true;
		}
	}
}