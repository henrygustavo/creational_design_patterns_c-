using System.Collections.Generic;

namespace CreationalDesignPatterns.Entities.Builder.Ordenacion
{

	public abstract class OrdenacionBuilder
	{
		public abstract List<string> Ordenar(string[] datos);
	}

}