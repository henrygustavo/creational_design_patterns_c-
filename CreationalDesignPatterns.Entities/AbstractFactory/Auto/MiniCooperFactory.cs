namespace CreationalDesignPatterns.Entities.AbstractFactory.Auto
{
	public class MiniCooperFactory : IAutoFactory
	{

		public virtual IAutoMobile CreateSportsCar()
		{
			MiniCooper mini = new MiniCooper();
			mini.AddSportPackage();
			return mini;
		}

		public virtual IAutoMobile CreateLuxuryCar()
		{
			MiniCooper mini = new MiniCooper();
			mini.AddLuxuryPackage();
			return mini;
		}

		public virtual IAutoMobile CreateEconomyCar()
		{
			return new MiniCooper();
		}
	}
}