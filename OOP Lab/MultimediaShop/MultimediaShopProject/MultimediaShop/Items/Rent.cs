using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultimediaShop.Enumerations;
using MultimediaShop.Interfaces;

namespace MultimediaShop.Items
{
    class Rent : IRent
    {
        private DateTime dateOfRent;
        private DateTime dateOfReturn;
        private DateTime deadlineDate;
        private Item rentItem;
        private EnumRent.State rentState;

        public Rent(DateTime dateOfRent, DateTime dateOfReturn, DateTime deadlineDate, 
            Item rentItem, EnumRent.State rentState)
        {
            this.DateOfRent = dateOfRent;
            this.DateOfReturn = dateOfReturn;
            this.DeadlineDate = deadlineDate;
            this.RentItem = rentItem;
            this.RentState = rentState;
        }

        public DateTime DateOfRent
        {
            get
            {
                return this.dateOfRent;
            }
            set
            {
                this.dateOfRent = value;
            }
        }

        public DateTime DateOfReturn
        {
            get
            {
                return this.dateOfReturn;
            }
            set
            {
                this.dateOfReturn = value;
            }
        }

        public DateTime DeadlineDate
        {
            get
            {
                return this.deadlineDate;
            }
            set
            {
                this.deadlineDate = value;
            }
        }

        public Item RentItem
        {
            get
            {
                return this.rentItem;
            }
            set
            {
                Validators.AssertObjectIsNotNull(value, "Rent Item");
                this.rentItem = value;
            }
        }

        public EnumRent.State RentState
        {
            get
            {
                return this.rentState;
            }
            set
            {
                this.rentState = value;
            }
        }

        public decimal CalculateRentFine()
        {
            throw new NotImplementedException();
        }
    }
}
