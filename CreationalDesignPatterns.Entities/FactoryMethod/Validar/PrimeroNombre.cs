using System;

namespace CreationalDesignPatterns.Entities.FactoryMethod.Validar
{
	public class PrimeroNombre : ValidaNombre
	{

		public PrimeroNombre(string nombreCompleto) : base(nombreCompleto)
		{

			int i = nombreCompleto.IndexOf(" ", StringComparison.Ordinal);

			nombre = nombreCompleto.Substring(0, i);
			apellido = nombreCompleto.Substring(i + 1);
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