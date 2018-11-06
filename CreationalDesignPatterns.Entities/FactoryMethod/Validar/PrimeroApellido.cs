using System;

namespace CreationalDesignPatterns.Entities.FactoryMethod.Validar
{
	public class PrimeroApellido : ValidaNombre
	{

		public PrimeroApellido(string nombreCompleto) : base(nombreCompleto)
		{

			int i = nombreCompleto.IndexOf(",", StringComparison.Ordinal);

			apellido = nombreCompleto.Substring(0, i);
			nombre = nombreCompleto.Substring(i + 1);
		}

		public override string ObtenerApellido()
		{
			return apellido;
		}

		public override string ObtenerNombre()
		{
			return nombre;
		}
	}
}