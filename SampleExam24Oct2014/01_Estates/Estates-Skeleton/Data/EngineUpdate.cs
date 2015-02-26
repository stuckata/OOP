using Estates.Engine;
using Estates.Interfaces;
using Estates.Data.Offers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    class EngineUpdate : EstateEngine
    {
        public override string ExecuteCommand(string cmdName, string[] cmdArgs)
        {
            switch (cmdName)
            {
                case "find-rents-by-location":
                    return this.ExecuteFindRentsByLocationCommand(cmdArgs[0]);
                case "find-rents-by-price":
                    return this.ExecuteFindRentsByPriceCommand(cmdArgs[0], cmdArgs[1]);
                default:
                    return base.ExecuteCommand(cmdName, cmdArgs);
            }
        }

        private string ExecuteFindRentsByLocationCommand(string location)
        {
            var offers = this.Offers
                .Where(o => o.Estate.Location == location && o.Type == OfferType.Rent)
                .OrderBy(o => o.Estate.Name);

            return FormatQueryResults(offers);
        }

        private string ExecuteFindRentsByPriceCommand(string minPrice, string maxPrice)
        {
            decimal min = decimal.Parse(minPrice);
            decimal max = decimal.Parse(maxPrice);

            var offers = this.Offers
                .Where(o => o.Type == OfferType.Rent)
                .Where(o => ((RentOffer)o).PricePerMonth >= min && ((RentOffer)o).PricePerMonth <= max)
                .OrderBy(o => ((RentOffer)o).PricePerMonth)
                .ThenBy(o => o.Estate.Name);

            return FormatQueryResults(offers);
        }
    }
}
