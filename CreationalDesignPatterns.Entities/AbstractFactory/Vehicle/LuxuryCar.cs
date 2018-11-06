namespace CreationalDesignPatterns.Entities.AbstractFactory.Vehicle
{
	public class LuxuryCar : Car
	{

		private string name;

		public LuxuryCar(string name)
		{
			this.name = name;
		}

		public string GetCarName()
		{
			
				return name;
		}

		public string GetCarFeatures()
        {
			
				return "Luxury Car Features ";
			
		}
	}
}