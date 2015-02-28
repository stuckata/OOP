using FarmersCreed.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersCreed.Units
{
    public class Cow : Animal
    {
        private const int COW_HEALTH = 15;
        private const int COW_QUANTITY = 6;
        private const int COW_HEALTH_EFFECT = 4;

        public Cow(string id)
            :base (id, COW_HEALTH, COW_QUANTITY, ProductType.Milk, FoodType.Organic, COW_HEALTH_EFFECT)
        {         
        }

        public override Product GetProduct()
        {
            Product product = base.GetProduct();
            if (product != null)
            {
                Health -= 2;
            }
            return product;
        }

        public override void Eat(IEdible food, int quantity)
        {
            base.Eat(food, quantity);
            if (food.FoodType.Equals(FoodType.Organic))
            {
                Health += food.HealthEffect * quantity;
            } else
            {
                Health -= food.HealthEffect * quantity;
            }
        }
    }
}
