namespace CreationalDesignPatterns.Entities.ProtoType
{
    using System.Diagnostics;
    using System.Collections.Generic;
    using System;

    public class Registry
    {
        private readonly Dictionary<string, Item> _items = new Dictionary<string, Item>();

        public Registry()
        {
            LoadItems();
        }

        public Item CreateItem(string type)
        {
            Item item = null;
            try
            {
                item = (Item)_items[type].Clone();
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
            }
            return item;
        }

        private void LoadItems()
        {
            Movie movie = new Movie
            {
                Title = "Basic Movie",
                Price = 24.99,
                Runtime = "2 hours"
            };

            _items.Add("Movie", movie);

            Book book = new Book
            {
                NumberOfPages = 335,
                Price = 19.99,
                Title = "Basic Book"
            };

            _items.Add("Book", book);
        }
    }
}
