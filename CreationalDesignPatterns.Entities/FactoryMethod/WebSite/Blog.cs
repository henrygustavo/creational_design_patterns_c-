namespace CreationalDesignPatterns.Entities.FactoryMethod.WebSite
{
	public class Blog : Website
	{

		public override void CreateWebsite()
		{
			pages.Add(new PostPage());
			pages.Add(new AboutPage());
			pages.Add(new CommentPage());
			pages.Add(new ContactPage());
		}

	}

}