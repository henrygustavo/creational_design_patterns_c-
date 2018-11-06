using System;

namespace CreationalDesignPatterns.Entities.FactoryMethod.Fecha
{
	public class FechasFactory
	{

		public virtual FechaGenerica ObtenerFecha()
		{

			ConfiguracionRegional config = ConfiguracionRegional.Instancia;

			if (config.Region.Equals(ConfiguracionRegional.REGION_EEUU, StringComparison.OrdinalIgnoreCase))
			{
				return new FechaEEUU();
			}
			else if (config.Region.Equals(ConfiguracionRegional.REGION_EUR, StringComparison.OrdinalIgnoreCase))
			{
				return new FechaEUR();
			}
			else
			{
				return new FechaLA();
			}
		}
	}
}