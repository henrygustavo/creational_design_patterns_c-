namespace CreationalDesignPatterns.Entities.Builder.Ordenacion
{
	public class OrdenacionFactory
	{

		public virtual OrdenacionBuilder GetOrdenacionBuilder(string @string)
		{
			OrdenacionBuilder builder = null;
			if (@string.Equals("QS"))
			{
				builder = new OrdenacionQuickSort();
			}
			return builder;
		}
	}

}