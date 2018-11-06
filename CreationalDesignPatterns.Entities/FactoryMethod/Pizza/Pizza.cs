using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CreationalDesignPatterns.Entities.FactoryMethod.Pizza
{

	public abstract class Pizza
	{
		internal string name;
		internal string dough;
		internal string sauce;
		internal List<string> toppings = new List<string>();

		public  void Prepare()
		{
			Debug.WriteLine("Preparing " + name);
			Debug.WriteLine("Tossing dough...");
			Debug.WriteLine("Adding sauce...");
			Debug.WriteLine("Adding toppings: ");
			for (int i = 0; i < toppings.Count; i++)
			{
				Debug.WriteLine("   " + toppings[i]);
			}
		}

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

		public  string Name
		{
			get
			{
				return name;
			}
		}

		public override string ToString()
		{
			StringBuilder display = new StringBuilder();
			display.Append("---- " + name + " ----\n");
			display.Append(dough + "\n");
			display.Append(sauce + "\n");
			for (int i = 0; i < toppings.Count; i++)
			{
				display.Append((string)toppings[i] + "\n");
			}
			return display.ToString();
		}
	}
}