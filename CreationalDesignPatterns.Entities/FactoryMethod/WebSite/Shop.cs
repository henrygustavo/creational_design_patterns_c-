namespace CreationalDesignPatterns.Entities.FactoryMethod.WebSite
{
	public class Shop : Website
	{

		public override void CreateWebsite()
		{
			pages.Add(new CartPage());
			pages.Add(new ItemPage());
			pages.Add(new SearchPage());
		}

	}

}