using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersCreed.Units
{
    public class CherryTree : FoodPlant
    {
        private const int CHERRY_TREE_HEALTH = 14;
        private const int CHERRY_TREE_GROWTIME = 3;
        private const int CHERRY_TREE_HEALTH_EFFECT = 2;
        private const int CHERRY_TREE_QUANTITY = 4;

        public CherryTree(string id)
            : base(id, CHERRY_TREE_HEALTH, CHERRY_TREE_QUANTITY, CHERRY_TREE_GROWTIME, 
                  ProductType.Cherry, FoodType.Organic, CHERRY_TREE_HEALTH_EFFECT)
        {
        }
    }
}
