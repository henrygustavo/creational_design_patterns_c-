namespace CreationalDesignPatterns.Entities.AbstractFactory.Vehicle
{
	public class NonLuxuryVehicleFactory : VehicleFactory
	{

		public override Car GetCar()
        {
			
				return new NonLuxuryCar("Non Luxury Car");
			
		}

		public override SUV GetSUV()
		{
			
				return new NonLuxurySUV("Non Luxury SUV");
			
		}
	}
}