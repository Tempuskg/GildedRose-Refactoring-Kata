using System.Collections.Generic;
using GildedRoseKata.Goods;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                var good = Good.Create(Items[i]);

                good.DegradeQuality();
            }
        }
    }
}
