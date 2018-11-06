namespace CreationalDesignPatterns.Entities.AbstractFactory.Vehicle
{
	public class NonLuxurySUV : SUV
	{

		private string name;

		public NonLuxurySUV(string sName)
		{
			name = sName;
		}

		public string GetSUVName()
		{
			
				return name;
			
		}

		public  string GetSUVFeatures()
        {
		
			return "Non-Luxury SUV Features ";
			
		}
	}
}