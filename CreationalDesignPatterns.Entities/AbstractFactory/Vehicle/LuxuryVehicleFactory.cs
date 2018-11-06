namespace CreationalDesignPatterns.Entities.AbstractFactory.Vehicle
{
	public class LuxuryVehicleFactory : VehicleFactory
	{

		public override Car GetCar()
		{
		
				return new LuxuryCar("Luxury Car");
			
		}

		public override SUV GetSUV()
		{
			
				return new LuxurySUV("Luxury SUV");
			
		}
	}
}