namespace CreationalDesignPatterns.Entities.AbstractFactory.Vehicle
{
	public abstract class VehicleFactory
	{

		public const string LUXURY_VEHICLE = "Luxury";
		public const string NON_LUXURY_VEHICLE = "Non-Luxury";

	    public abstract Car GetCar();
		public abstract SUV GetSUV();

        public static VehicleFactory GetVehicleFactory(string type)
		{

			if (type.Equals(VehicleFactory.LUXURY_VEHICLE))
			{
				return new LuxuryVehicleFactory();
			}

			if (type.Equals(VehicleFactory.NON_LUXURY_VEHICLE))
			{
				return new NonLuxuryVehicleFactory();
			}

			return new LuxuryVehicleFactory();
		}
	}
}