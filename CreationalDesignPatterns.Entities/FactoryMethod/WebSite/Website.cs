using System.Collections.Generic;

namespace CreationalDesignPatterns.Entities.FactoryMethod.WebSite
{

	public abstract class Website
	{

		protected internal IList<Page> pages = new List<Page>();

		public virtual IList<Page> Pages
		{
			get
			{
				return pages;
			}
		}

		public Website()
		{
			this.CreateWebsite();
		}

		public abstract void CreateWebsite();

	}

}