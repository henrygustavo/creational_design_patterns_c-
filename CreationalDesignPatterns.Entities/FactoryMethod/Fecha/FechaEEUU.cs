using System;

namespace CreationalDesignPatterns.Entities.FactoryMethod.Fecha
{

	public class FechaEEUU : FechaGenerica
	{

		public override string ObtenerFecha()
		{
			DateTime cal = new DateTime();
			int anio = cal.Year;
			int mes = cal.Month + 1;
			int dia = cal.Day;

			return (mes + "/" + dia + "/" + anio);
		}
	}
}