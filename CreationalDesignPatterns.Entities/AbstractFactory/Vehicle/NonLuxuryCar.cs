namespace CreationalDesignPatterns.Entities.AbstractFactory.Vehicle
{
	public class NonLuxuryCar : Car
	{

		private string name;

		public NonLuxuryCar(string cName)
		{
			name = cName;
		}

		public  string GetCarName()
		{
		
		    return name;
			
		}

		public  string GetCarFeatures()
		{
			return "Non-Luxury Car Features ";
			
		}
	}
}