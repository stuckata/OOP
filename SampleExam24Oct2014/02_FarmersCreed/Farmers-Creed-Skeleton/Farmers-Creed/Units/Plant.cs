namespace FarmersCreed.Units
{
    using System;

    public abstract class Plant : FarmUnit
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
    }
}
