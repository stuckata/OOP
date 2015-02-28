namespace FarmersCreed.Units
{
    using System;
    using FarmersCreed.Interfaces;

    public abstract class Animal : FarmUnit
    {
        public Animal(string id, int health, int productionQuantity, ProductType productType, FoodType foodType, int healthEffect)
            : base(id, health, healthEffect, productionQuantity, productType, foodType)
        {
        }

        public virtual void Eat(IEdible food, int quantity)
        {
            if (food.Quantity >= quantity)
            {
                food.Quantity -= quantity;
            }      
        }

        public void Starve()
        {
            Health -= 1;
        }
    }
}
