using System;
using System.Diagnostics;

namespace CreationalDesignPatterns.Entities.FactoryMethod.Cars
{
	public class AudiTTS : IAuto
	{

		public  string GetName()
        {
			return "Audi TTS";
			
		}

		public  void TurnOn()
		{
			Debug.WriteLine("The Audi TTS is running, but there is an electrical fire.");
		}

		public  void TurnOff()
		{
			Debug.WriteLine("The Audi TTS is off, but the dashboard is still smoking.");
		}
	}
}