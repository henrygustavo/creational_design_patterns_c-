using System;
using System.Diagnostics;

namespace CreationalDesignPatterns.Entities.FactoryMethod.Logger
{
	public class ConsoleLogger : ILogger
	{
		public virtual void Log(string message)
		{
			Debug.WriteLine("Console: " + message);
		}
	}

}