namespace FarmersCreed.Units
{
    using System;

    public abstract class Plant : FarmUnit
    {
        private bool hasGrown;
        private int growTime;

        public Plant(string id, int health, int productionQuantity, int growTime, ProductType productType)
            : base(id, health, productionQuantity)
        {
            this.GrowTime = growTime;
            this.ProductType = productType;
        }

        public ProductType ProductType { get; set; }

        public bool HasGrown
        {
            get { return this.hasGrown; }
        }

        public int GrowTime
        {
            get { return this.growTime; }
            set { this.growTime = value; }
        }

        public virtual void Water()
        {
            Health += 2;
        }

        public virtual void Wither()
        {
            Health -= 1;
        }

        public virtual void Grow()
        {
            this.GrowTime -= 1;
        }

        public override Product GetProduct()
        {
            if (HasGrown && IsAlive)
            {
                return new Product(Id, ProductType, ProductionQuantity);
            }
            return null;
        }


    }
}
