using System.Collections.Generic;

namespace CreationalDesignPatterns.Entities.Builder.Ordenacion
{

	public class OrdenacionQuickSort : OrdenacionBuilder
	{

		internal string[] datos = null;

		public override List<string> Ordenar(string[] datos)
		{

			this.datos = datos;
			QuickSort(0, datos.Length - 1);
			List<string> resp = new List<string>();
			for (int i = 0; i < datos.Length; i++)
			{
				resp.Add(datos[i]);
			}
			return resp;
		}

		public virtual void QuickSort(int izq, int der)
		{
			string pivot;
			int sizq, sder;
			int ieq;
			string tmpVal;

			if (izq >= der)
			{
				return;
			}

			pivot = datos[(izq + der) / 2];

			ieq = sizq = izq;
			sder = der;

			while (sizq <= sder)
			{
				if (datos[sder].CompareTo(pivot) > 0)
				{
					sder--;
				}
				else
				{
					tmpVal = datos[sizq];
					datos[sizq] = datos[sder];
					datos[sder] = tmpVal;
					if (datos[sizq].CompareTo(pivot) < 0)
					{
						tmpVal = datos[ieq];
						datos[ieq] = datos[sizq];
						datos[sizq] = tmpVal;
						ieq++;
					}
					sizq++;
				}
			}
			QuickSort(izq, ieq - 1);
			QuickSort(sder + 1, der);
		}
	}

}