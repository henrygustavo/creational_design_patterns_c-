namespace CreationalDesignPatterns.Entities.AbstractFactory.Vehicle
{
	public class LuxurySUV : SUV
	{

		private string name;

		public LuxurySUV(string name)
		{
			this.name = name;
		}

		public string GetSUVName()
		{
			
				return name;
			
		}

		public  string GetSUVFeatures()
		{
			
				return "Luxury SUV Features ";
			
		}
	}
}