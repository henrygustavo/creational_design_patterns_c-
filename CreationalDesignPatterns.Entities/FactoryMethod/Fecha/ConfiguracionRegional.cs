namespace CreationalDesignPatterns.Entities.FactoryMethod.Fecha
{
	public class ConfiguracionRegional
	{

		private static ConfiguracionRegional unicaInstancia = null;
		public const string REGION_EEUU = "EEUU";
		public const string REGION_LA = "LA";
		public const string REGION_EUR = "EUR";

		private string region = null;

		public virtual string Region
		{
			get
			{
				return region;
			}
			set
			{
				this.region = value;
			}
		}


		public static ConfiguracionRegional Instancia
		{
			get
			{
				if (unicaInstancia != null)
				{
					return unicaInstancia;
				}
				lock (typeof(ConfiguracionRegional))
				{
					if (unicaInstancia == null)
					{
						unicaInstancia = new ConfiguracionRegional();
					}
				}
				return unicaInstancia;
			}
		}
	}
}