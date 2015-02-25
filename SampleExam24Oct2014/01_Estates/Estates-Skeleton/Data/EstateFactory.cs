using Estates.Engine;
using Estates.Interfaces;
using System;

namespace Estates.Data
{
    public class EstateFactory
    {
        public static IEstateEngine CreateEstateEngine()
        {
            return new EstateEngine();
        }

        public static IEstate CreateEstate(EstateType type, string name, double area, string location, bool isFurnitured, int numberOfRooms, bool hasElevator)
        {
            throw new NotImplementedException();
        }

        public static IOffer CreateOffer(OfferType type)
        {
            throw new NotImplementedException();
        }
    }
}
