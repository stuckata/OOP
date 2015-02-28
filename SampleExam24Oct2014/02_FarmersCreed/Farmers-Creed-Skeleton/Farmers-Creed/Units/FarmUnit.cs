using FarmersCreed.Interfaces;

namespace FarmersCreed.Units
{
    using System;

    public abstract class FarmUnit : GameObject, IProductProduceable 
    {
        public FarmUnit(string id, int health, int healthEffect, int productionQuantity, ProductType productType, FoodType foodType)
            : base(id)
        {
            this.Health = health;
            this.HealthEffect = healthEffect;
            this.ProductionQuantity = productionQuantity;
            this.ProductType = productType;
            this.FoodType = foodType;
        }

        public FarmUnit(string id, int health, int healthEffect, int productionQuantity, ProductType productType)
            : base(id)
        {
            this.Health = health;
            this.HealthEffect = healthEffect;
            this.ProductionQuantity = productionQuantity;
            this.ProductType = productType;
        }

        public FoodType FoodType { get; set; }

        public ProductType ProductType { get; set; }

        public int Health { get; set; }

        public int HealthEffect { get; set; }

        public bool IsAlive
        {
            get { return Health > 0; }
        }

        public int ProductionQuantity { get; set; }

        public virtual Product GetProduct()
        {
            if (IsAlive)
            {
                return new Product(Id, ProductType, ProductionQuantity);
            }
            return null;
        }
    }
}
