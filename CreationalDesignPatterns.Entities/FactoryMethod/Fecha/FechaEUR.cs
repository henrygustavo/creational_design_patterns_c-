using System;

namespace CreationalDesignPatterns.Entities.FactoryMethod.Fecha
{

	public class FechaEUR : FechaGenerica
	{

		public override string ObtenerFecha()
		{
			DateTime cal = new DateTime();
			int anio = cal.Year;
			int mes = cal.Month + 1;
			int dia = cal.Day;

			return (dia + "/" + mes + "/" + anio);
		}
	}
}