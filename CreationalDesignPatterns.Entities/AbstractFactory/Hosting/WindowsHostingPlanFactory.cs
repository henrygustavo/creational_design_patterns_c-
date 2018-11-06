namespace CreationalDesignPatterns.Entities.AbstractFactory.Hosting
{
	public class WindowsHostingPlanFactory : HostingPlanAbstractFactory
	{

		public override EconomyHostingPlan CreateEconomyHosting()
		{
			return new WindowsEconomyHostingPlan();
		}

		public override DeluxeHostingPlan CreateDeluxeHosting()
		{
			return new WindowsDeluxeHostingPlan();
		}

		public override UltimateHostingPlan CreateUltimateHosting()
		{
			return new WindowsUltimateHostingPlan();
		}

	}

}