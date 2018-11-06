using System.Diagnostics;
using System.Text;

namespace CreationalDesignPatterns.Entities.AbstractFactory.Pizza
{
	public abstract class Pizza
	{
		internal string name;

		internal Dough dough;
		internal Sauce sauce;
		internal Veggies[] veggies;
		internal Cheese cheese;
		internal Pepperoni pepperoni;
		internal Clams clam;

		internal abstract void Prepare();

		internal virtual void Bake()
		{
			Debug.WriteLine("Bake for 25 minutes at 350");
		}

		internal virtual void Cut()
		{
			Debug.WriteLine("Cutting the pizza into diagonal slices");
		}

		internal virtual void Box()
		{
			Debug.WriteLine("Place pizza in official PizzaStore box");
		}

		internal virtual string Name
		{
			set
			{
				this.name = value;
			}
			get
			{
				return name;
			}
		}


		public override string ToString()
		{
			StringBuilder result = new StringBuilder();
			result.Append("---- " + name + " ----\n");
			if (dough != null)
			{
				result.Append(dough);
				result.Append("\n");
			}
			if (sauce != null)
			{
				result.Append(sauce);
				result.Append("\n");
			}
			if (cheese != null)
			{
				result.Append(cheese);
				result.Append("\n");
			}
			if (veggies != null)
			{
				for (int i = 0; i < veggies.Length; i++)
				{
					result.Append(veggies[i]);
					if (i < veggies.Length - 1)
					{
						result.Append(", ");
					}
				}
				result.Append("\n");
			}
			if (clam != null)
			{
				result.Append(clam);
				result.Append("\n");
			}
			if (pepperoni != null)
			{
				result.Append(pepperoni);
				result.Append("\n");
			}
			return result.ToString();
		}
	}
}