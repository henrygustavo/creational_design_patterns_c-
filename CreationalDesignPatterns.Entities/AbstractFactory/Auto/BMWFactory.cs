namespace CreationalDesignPatterns.Entities.AbstractFactory.Auto
{
	public class BMWFactory : IAutoFactory
	{

		public virtual IAutoMobile CreateSportsCar()
		{
			return new BMWM3();
		}

		public virtual IAutoMobile CreateLuxuryCar()
		{
			return new BMW740i();
		}

		public virtual IAutoMobile CreateEconomyCar()
		{
			return new BMW328i();
		}
	}
}