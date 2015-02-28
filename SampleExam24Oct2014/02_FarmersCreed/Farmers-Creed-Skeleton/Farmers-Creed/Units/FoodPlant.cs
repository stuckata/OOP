﻿using FarmersCreed.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersCreed.Units
{
    public abstract class FoodPlant : Plant, IEdible
    {
        public FoodPlant(string id, int health, int productionQuantity, int growTime,
           ProductType productType, FoodType foodType, int healthEffect)
               : base(id, health, productionQuantity, growTime, productType)
        {
            this.FoodType = foodType;
            this.HealthEffect = healthEffect;
            this.Quantity = productionQuantity;
        }

        public FoodType FoodType { get; set; }
        public int HealthEffect { get; set; }
        public int Quantity { get; set; }

        public override void Water()
        {
            Health += 2;
        }

        public override void Wither()
        {
            Health -= 2;
        }
    }
}
