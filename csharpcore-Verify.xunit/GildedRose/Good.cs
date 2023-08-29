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
                case Sulfuras: return new Sulfuras(item);
                default:                                          return new GoodNullable(item);
            }
        }

        public virtual string Name    => _item.Name;
        public         int    Quality
        {
            get => _item.Quality;
            set => _item.Quality = value;
        }

        public int SellIn 
        { 
            get => _item.SellIn;
            set => _item.SellIn = value;
        }

        public virtual void DegradeQuality()
        {
                if (Quality > 0)
                {
                    if (Name != Good.Sulfuras)
                    {
                        Quality = Quality - 1;
                    }
                }

                if (Name != Good.Sulfuras)
                {
                    SellIn = SellIn - 1;
                }

                if (SellIn < 0)
                {
                
                    if (Quality > 0)
                    {
                        if (Name != Good.Sulfuras)
                        {
                            Quality = Quality - 1;
                        }
                    }
                
                }
        }
    }
}
