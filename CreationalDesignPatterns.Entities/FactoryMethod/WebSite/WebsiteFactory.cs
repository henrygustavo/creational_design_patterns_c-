namespace CreationalDesignPatterns.Entities.FactoryMethod.WebSite
{
	public class WebsiteFactory
	{

		public static Website GetWebsite(WebsiteType siteType)
		{
			switch (siteType)
			{
				case CreationalDesignPatterns.Entities.FactoryMethod.WebSite.WebsiteType.BLOG:
				{
					return new Blog();
				}

				case CreationalDesignPatterns.Entities.FactoryMethod.WebSite.WebsiteType.SHOP:
				{
					return new Shop();
				}

				default :
				{
					return null;
				}
			}
		}

	}
}