using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultimediaShop.Interfaces;

namespace MultimediaShop.Items
{
    class Sale : ISale
    {
        private DateTime dateOfPurchase;
        private Item saleItem;

        public Sale(DateTime dateOfPurchase, Item saleItem)
        {
            this.DateOfPurchase = dateOfPurchase;
            this.SaleItem = saleItem;
        }

        public DateTime DateOfPurchase
        {
            get
            {
                return this.dateOfPurchase;
            }
            set
            {
                this.dateOfPurchase = value;
            }
        }

        public Item SaleItem
        {
            get
            {
                return this.saleItem;
            }
            set
            {
                this.saleItem = value;
            }
        }
    }
}
