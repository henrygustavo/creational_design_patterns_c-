using System;

namespace CreationalDesignPatterns.Entities.FactoryMethod.Validar
{
	public class NombreCompletoFactory
	{

		public NombreCompletoFactory()
		{
		}

		public static ValidaNombre ObtenerValidador(string nombreCompleto)
		{
			int i = nombreCompleto.IndexOf(",", StringComparison.Ordinal);
			if (i > 0)
			{
				return (new PrimeroApellido(nombreCompleto));
			}
			else
			{
				return (new PrimeroNombre(nombreCompleto));
			}
		}
	}
}