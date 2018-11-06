namespace CreationalDesignPatterns.Entities.AbstractFactory.Hosting
{
	public abstract class HostingPlanAbstractFactory
    {
		public const string WINDOWS = "Windows";
		public const string LINUX = "Linux";

		public static HostingPlanAbstractFactory GetHostingFactory(string type)
		{
			if (type.Equals(HostingPlanAbstractFactory.WINDOWS))
			{
				return new WindowsHostingPlanFactory();
			}
			if (type.Equals(HostingPlanAbstractFactory.LINUX))
			{
				return new LinuxHostingPlanFactory();
			}
			return new LinuxHostingPlanFactory();
		}

		public abstract EconomyHostingPlan CreateEconomyHosting();

		public abstract DeluxeHostingPlan CreateDeluxeHosting();

		public abstract UltimateHostingPlan CreateUltimateHosting();
	}

}