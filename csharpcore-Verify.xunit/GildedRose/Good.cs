using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRoseKata.Goods;

namespace GildedRoseKata
{
    public abstract class Good
    {
        public const string AgedBrie             = "Aged Brie";
        public const string BackStageTAFKAL80ETC = "Backstage passes to a TAFKAL80ETC concert";

        public static Good Create(Item item)
        {
            switch (item.Name)
            {
                case AgedBrie:                                 return new AgedBrie(item);
                case BackStageTAFKAL80ETC: return new BackStageTAFKAL80ETC(item);
                default:                                          return new GoodNullable(item);
            }
        }

        public abstract string Name { get ; }
    }
}
