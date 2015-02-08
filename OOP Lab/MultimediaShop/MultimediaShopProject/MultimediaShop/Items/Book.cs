using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediaShop.Items
{
    class Book : Item
    {
        private string author;

        public Book(List<string> genres, string id, decimal price, string title, string author)
            : base(genres, id, price, title)
        {
            this.Author = author;
        }

        public Book(string genre, string id, decimal price, string title, string author)
            : base((new List<string>{ genre }), id, price, title)
        {
            this.Author = author;
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                Validators.AssertStringIsValid(value, 3, "Author");
                this.author = value;
            }
        }
    }
}
