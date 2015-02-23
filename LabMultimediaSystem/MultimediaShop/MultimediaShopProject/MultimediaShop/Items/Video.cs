using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediaShop.Items
{
    class Video : Item
    {
        private int length;

        public Video(List<string> genres, string id, decimal price, string title, int length)
            : base(genres, id, price, title)
        {
            this.Length = length;
        }

        public Video(string genre, string id, decimal price, string title, int length)
            : base((new List<string> { genre }), id, price, title)
        {
            this.Length = length;
        }

        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
            }
        }
    }
}
