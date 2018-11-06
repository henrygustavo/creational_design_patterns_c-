using System.Collections.Generic;
using System.Diagnostics;

namespace CreationalDesignPatterns.Entities.Builder.Sandwich
{

	public class Sandwich
	{
		private BreadType breadType;
		private bool isToasted;
		private CheeseType cheeseType;
		private MeatType meatType;
		private bool hasMustard;
		private bool hasMayo;
		private IList<string> vegetables;

		public virtual BreadType BreadType
		{
			get
			{
				return breadType;
			}
			set
			{
				this.breadType = value;
			}
		}


		public virtual bool Toasted
		{
			get
			{
				return isToasted;
			}
			set
			{
				this.isToasted = value;
			}
		}


		public virtual CheeseType CheeseType
		{
			get
			{
				return cheeseType;
			}
			set
			{
				this.cheeseType = value;
			}
		}


		public virtual MeatType MeatType
		{
			get
			{
				return meatType;
			}
			set
			{
				this.meatType = value;
			}
		}


		public virtual bool HasMustard
		{
			get
			{
				return hasMustard;
			}
			set
			{
				this.hasMustard = value;
			}
		}


		public virtual bool HasMayo
		{
			get
			{
				return hasMayo;
			}
			set
			{
				this.hasMayo = value;
			}
		}


		public virtual IList<string> Vegetables
		{
			get
			{
				return vegetables;
			}
			set
			{
				this.vegetables = value;
			}
		}


		public virtual void Display()
		{

			Debug.WriteLine($"Sandwich on {breadType} bread\n");
			if (isToasted)
			{
				Debug.WriteLine("Toasted\n");
			}
			if (hasMayo)
			{
				Debug.WriteLine("With Mayo\n");
			}
			if (hasMustard)
			{
				Debug.WriteLine("With Mustard\n");
			}

			Debug.WriteLine($"Meat: {meatType}\n");

			Debug.WriteLine($"Cheese: {cheeseType}\n");
			Debug.WriteLine("Veggies: \n");
			foreach (string vegetable in vegetables)
			{
				Debug.WriteLine($"   {vegetable}\n", vegetable);
			}
			Debug.WriteLine("******************************\n\n");
		}
	}
}