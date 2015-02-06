using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultimediaShop.Items;
using MultimediaShop.Enumerations;

namespace MultimediaShop.Interfaces
{
    interface IRent
    {
        Item RentItem { get; set; }
        EnumRent.State RentState { get; set; }
        DateTime DateOfRent { get; set; }
        DateTime DeadlineDate { get; set; }
        DateTime DateOfReturn { get; set; }
        decimal CalculateRentFine();
    }
}
