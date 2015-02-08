using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultimediaShop.Interfaces;

namespace MultimediaShop.Items
{
    class Item : IItem
    {
        private Dictionary<string, List<Item>> genres;
        private string id;
        private decimal price;
        private string title;

        public Item(Dictionary<string, List<Item>> genres, string id, decimal price, string title)
        {
            this.Genres = genres;
            this.Id = id;
            this.Price = price;
            this.Title = title;
        }

        public Dictionary<string, List<Item>> Genres
        {
            get
            {
                return this.genres;
            }
            set
            {
                this.genres = value;
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                Validators.AssertStringIsValid(value, 4, "Id");
                this.id = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                Validators.AssertMinValue(value, 0, "Price");
                this.price = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                Validators.AssertStringIsValid(value, 1, "Title");
                this.title = value;
            }
        }
    }
}
