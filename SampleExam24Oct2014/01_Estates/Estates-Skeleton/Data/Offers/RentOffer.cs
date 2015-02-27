using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data.Offers
{
    public class RentOffer : Offer, IRentOffer
    {
        private decimal pricePerMonth;

        public RentOffer(OfferType type, IEstate estate, decimal pricePerMonth)
            : base(type, estate)
        {
            this.PricePerMonth = pricePerMonth;
        }

        public RentOffer()
        {
            this.Type = OfferType.Rent;
        }

        public decimal PricePerMonth
        {
            get
            {
                return this.pricePerMonth;
            }

            set
            {
                this.pricePerMonth = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}, Price = {1}", base.ToString(), this.PricePerMonth);
        }
    }
}
