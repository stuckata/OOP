﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersCreed.Units
{
    class TobaccoPlant : Plant
    {
        private const int TOBACCO_HEALTH = 12;
        private const int TOBACCO_GROWTIME = 4;
        private const int PRODUCTION_QUANTITY = 10;

        public TobaccoPlant(string id)
            : base(id, TOBACCO_HEALTH, PRODUCTION_QUANTITY, TOBACCO_GROWTIME)
        {           
        }

        public override void Grow()
        {
            this.GrowTime -= 2;
        }

        public override Product GetProduct()
        {
            if (HasGrown && IsAlive)
            {
                return new Product(Id, ProductType.Tobacco, ProductionQuantity);
            }
            return null;
        }
    }
}
