using FarmersCreed.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersCreed.Units
{
    public abstract class FoodPlant : Plant, IEdible
    {

        public abstract FoodType FoodType { get; set; }
        public abstract int HealthEffect { get; set; }
        public abstract ProductType ProductType { get; set; }
        public abstract int Quantity { get; set; }

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
