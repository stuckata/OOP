using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data.Offers
{
    public class SaleOffer : Offer, ISaleOffer
    {
        private decimal price;

        public SaleOffer(OfferType type, IEstate estate, decimal price)
            : base(type, estate)
        {
            this.Price = price;
        }

        public SaleOffer()
        {
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.price = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}, Price = {1}", base.ToString(), this.Price);
        }
    }
}
