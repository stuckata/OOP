using Estates.Engine;
using Estates.Interfaces;
using System;

namespace Estates.Data
{
    public class EstateFactory
    {
        public static IEstateEngine CreateEstateEngine()
        {
            return new EngineUpdate();
        }

        public static IEstate CreateEstate(EstateType type)
        {
            switch (type)
            {
                case EstateType.Apartment:
                    return new Estates.Apartment();
                case EstateType.Office:
                    return new Estates.Office();
                case EstateType.House:
                    return new Estates.House();
                case EstateType.Garage:
                    return new Estates.Garage();
                default:
                    throw new NotSupportedException("No such estate type!");
            }
        }

        public static IOffer CreateOffer(OfferType type)
        {
            switch (type)
            {
                case OfferType.Sale:
                    return new Offers.SaleOffer();
                case OfferType.Rent:
                    return new Offers.RentOffer();
                default:
                    throw new NotSupportedException("No such offer type!");
            }
        }
    }
}
