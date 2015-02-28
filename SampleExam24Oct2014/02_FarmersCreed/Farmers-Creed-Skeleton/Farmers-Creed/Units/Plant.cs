namespace FarmersCreed.Units
{
    using System;

    public class Plant : FarmUnit
    {
        private bool hasGrown;
        private int growTime;

        public Plant(string id, int health, int productionQuantity, int growTime)
            : base(id, health, productionQuantity)
        {
            this.GrowTime = growTime;
        }

        public bool HasGrown
        {
            get { return this.hasGrown; }
        }

        public int GrowTime
        {
            get { return this.growTime; }
            set { this.growTime = value; }
        }

        public void Water()
        {
            Health += 2;
        }

        public void Wither()
        {
            Health -= 1;
        }

        public void Grow()
        {
            this.GrowTime -= 1;
        }
    }
}
