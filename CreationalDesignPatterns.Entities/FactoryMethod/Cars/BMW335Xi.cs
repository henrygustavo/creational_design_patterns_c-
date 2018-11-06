using System;
using System.Diagnostics;

namespace CreationalDesignPatterns.Entities.FactoryMethod.Cars
{
	public class BMW335Xi : IAuto
	{

	    public string GetName()
        {
			return "BMW 335Xi";
		}

		public void TurnOn()
		{
			Debug.WriteLine("The BMW 335Xi is on and running.");
		}

		public void TurnOff()
		{
			Debug.WriteLine("The BMW 335Xi is off.");
		}
	}
}