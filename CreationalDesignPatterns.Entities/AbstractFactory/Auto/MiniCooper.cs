using System.Diagnostics;

namespace CreationalDesignPatterns.Entities.AbstractFactory.Auto
{
	public class MiniCooper : IAutoMobile
	{

		private string name;

		public MiniCooper()
		{
			this.name = "Mini Cooper";
		}

		public virtual void AddSportPackage()
		{
			name += " S";
		}

		public virtual void AddLuxuryPackage()
		{
			name += " with leather upholstery";
		}

		public virtual void TurnOn()
		{
			Debug.WriteLine("The " + name + " is on! 1.6 Liters of brutal force is churning.");

		}

		public virtual void TurnOff()
		{
			Debug.WriteLine("The " + name + " is has turned off.");
		}
	}
}