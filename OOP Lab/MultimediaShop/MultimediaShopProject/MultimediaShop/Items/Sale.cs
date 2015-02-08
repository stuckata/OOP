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

        public Sale(Item saleItem, DateTime dateOfPurchase)
        {
            this.SaleItem = saleItem;
            this.DateOfPurchase = dateOfPurchase;         
        }

        public Sale(Item saleItem)
        {
            this.SaleItem = saleItem;
            this.DateOfPurchase = DateTime.Now;
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
                Validators.AssertObjectIsNotNull(value, "Sale Item");
                this.saleItem = value;
            }
        }
    }
}
