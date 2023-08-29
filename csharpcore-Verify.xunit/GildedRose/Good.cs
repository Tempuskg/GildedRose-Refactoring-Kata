using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRoseKata.Goods;

namespace GildedRoseKata
{
    public abstract class Good
    {
        private readonly Item   _item;
        public const     string AgedBrie             = "Aged Brie";
        public const     string BackStageTAFKAL80ETC = "Backstage passes to a TAFKAL80ETC concert";
        public const     string Sulfuras             = "Sulfuras, Hand of Ragnaros";
        public const     string Conjured             = "Conjured Mana Cake";

        protected Good(Item item)
        {
            _item = item;
        }

        public static Good Create(Item item)
        {
            switch (item.Name)
            {
                case AgedBrie:                                 return new AgedBrie(item);
                case BackStageTAFKAL80ETC: return new BackStageTAFKAL80ETC(item);
                default:                                          return new GoodNullable(item);
            }
        }

        public virtual string Name => _item.Name;
    }
}
