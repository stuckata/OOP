namespace FarmersCreed.Units
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FarmersCreed.Interfaces;

    public class Farm : GameObject, IFarm
    {
        public Farm(string id)
            : base(id)
        {
        }

        public List<Plant> Plants { get; }

        public List<Animal> Animals { get; }

        public List<Product> Products { get; }

        public void AddProduct(Product product)
        {
            if (this.Products.Any(p => p.Id == product.Id))
            {
                product.Quantity++;
            }
            else
            {
                this.Products.Add(product);
            }           
        }

        public void AddCherryTree(string id)
        {
            this.Plants.Add(new CherryTree(id));
        }

        public void AddTobaccoPlant(string id)
        {
            this.Plants.Add(new TobaccoPlant(id));
        }

        public void AddCow(string id)
        {
            this.Animals.Add(new Cow(id));
        }

        public void AddSwine(string id)
        {
            this.Animals.Add(new Swine(id));
        }

        public void Exploit(IProductProduceable productProducer)
        {
            productProducer.GetProduct();
        }

        public void Feed(Animal animal, IEdible edibleProduct, int productQuantity)
        {
            animal.Eat(edibleProduct, productQuantity);
        }

        public void Water(Plant plant)
        {
            plant.Water();
        }

        public void UpdateFarmState()
        {
            // TODO: Process all animal and plant behavior
            throw new NotImplementedException();
        }
    }
}
