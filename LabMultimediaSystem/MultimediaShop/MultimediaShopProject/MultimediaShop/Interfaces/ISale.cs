using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultimediaShop.Items;

namespace MultimediaShop.Interfaces
{
    interface ISale
    {
        Item SaleItem { get; set; }
        DateTime DateOfPurchase { get; set; }
    }
}
