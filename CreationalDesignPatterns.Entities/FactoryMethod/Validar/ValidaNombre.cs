namespace CreationalDesignPatterns.Entities.FactoryMethod.Validar
{
	public abstract class ValidaNombre
	{

		internal string nombreCompleto = null;
		internal string apellido = null;
		internal string nombre = null;

		public ValidaNombre(string nombreCompleto)
		{
			this.nombreCompleto = nombreCompleto;
		}

		public abstract string ObtenerNombre();
		public abstract string ObtenerApellido();
	}
}