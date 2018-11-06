using System.Diagnostics;

namespace CreationalDesignPatterns.Entities.AbstractFactory.Auto
{
	public abstract class BMWBase : IAutoMobile
	{

	    public abstract string GetName();

		public virtual void TurnOn()
		{
			Debug.WriteLine("The " + GetName() + " is on and running.");
		}

		public virtual void TurnOff()
		{
			Debug.WriteLine("The " + GetName() + " is off.");
		}
	}
}