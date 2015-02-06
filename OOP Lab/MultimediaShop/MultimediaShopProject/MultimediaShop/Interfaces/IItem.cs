using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultimediaShop.Items;

namespace MultimediaShop.Interfaces
{
    interface IItem
    {
        string Id { get; set; }
        string Title { get; set; }
        decimal Price { get; set; }
        Dictionary<string, List<Item>> Genres { get; set; }
    }
}
