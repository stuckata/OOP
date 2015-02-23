using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultimediaShop.Enumerations;

namespace MultimediaShop.Items
{
    class Game : Item
    {
        private AgeRestrictionTypes ageRestriction;

        public Game(List<string> genres, string id, decimal price, string title,
            AgeRestrictionTypes ageRestriction = AgeRestrictionTypes.Minor)
                : base(genres, id, price, title)
        {
            this.AgeRestriction = ageRestriction;
        }

        public Game(string genre, string id, decimal price, string title,
            AgeRestrictionTypes ageRestriction = AgeRestrictionTypes.Minor)
                : base((new List<string> { genre }), id, price, title)
        {
            this.AgeRestriction = ageRestriction;
        }

        public AgeRestrictionTypes AgeRestriction
        {
            get
            {
                return this.ageRestriction;
            }
            set
            {
                this.ageRestriction = value;
            }
        }
    }
}
