using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRoseKata.Goods;

namespace GildedRoseKata
{
    public abstract class Good
    {
        public static Good Create(Item item)
        {
            switch (item.Name)
            {
                case "Aged Brie": return new AgedBrie(item);
                default: return new GoodNullable(item);
            }
        }

        public abstract string Name { get ; }
    }
}
