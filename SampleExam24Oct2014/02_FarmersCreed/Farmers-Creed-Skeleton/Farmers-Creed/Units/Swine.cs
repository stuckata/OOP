using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmersCreed.Interfaces;

namespace FarmersCreed.Units
{
    public class Swine : Animal
    {
        private const int SWINE_HEALTH = 20;
        private const int SWINE_QUANTITY = 1;
        private const int SWINE_HEALTH_EFFECT = 5;

        public Swine(string id)
            :base (id, SWINE_HEALTH, SWINE_QUANTITY, ProductType.PorkMeat, FoodType.Meat, SWINE_HEALTH_EFFECT)
        {
        }

        public override Product GetProduct()
        {
            Product product = base.GetProduct();
            Health = 0;
            return product;
        }

        public override void Starve()
        {
            Health -= 3;
        }

        public override void Eat(IEdible food, int quantity)
        {
            base.Eat(food, quantity);         
            Health += food.HealthEffect * 2;          
        }
    }
}
