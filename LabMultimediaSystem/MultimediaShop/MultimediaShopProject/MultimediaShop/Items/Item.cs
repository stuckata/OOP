using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultimediaShop.Interfaces;

namespace MultimediaShop.Items
{
    abstract class Item : IItem
    {
        private List<string> genres;
        private string id;
        private decimal price;
        private string title;

        public Item(List<string> genres, string id, decimal price, string title)
        {
            this.Genres = genres;
            this.Id = id;
            this.Price = price;
            this.Title = title;
        }

        public Item(string id, decimal price, string title)
        {
            this.Id = id;
            this.Price = price;
            this.Title = title;
        }

        public List<string> Genres
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
