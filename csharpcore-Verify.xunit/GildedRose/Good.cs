﻿using GildedRoseKata.Goods;

namespace GildedRoseKata
{
    public abstract class Good
    {
        private readonly Item _item;
        public const string AgedBrie = "Aged Brie";
        public const string BackStageTAFKAL80ETC = "Backstage passes to a TAFKAL80ETC concert";
        public const string Sulfuras = "Sulfuras, Hand of Ragnaros";
        public const string Conjured = "Conjured Mana Cake";

        protected Good(Item item)
        {
            _item = item;
        }

        public static Good Create(Item item)
        {
            return item.Name switch
            {
                AgedBrie             => new AgedBrie(item),
                BackStageTAFKAL80ETC => new BackStageTAFKAL80ETC(item),
                Sulfuras             => new Sulfuras(item),
                _                    => new NormalGood(item),
            };
        }

        public int Quality
        {
            get => _item.Quality;
            set => _item.Quality = value;
        }

        public int SellIn
        {
            get => _item.SellIn;
            set => _item.SellIn = value;
        }

        public abstract void DegradeQuality();
    }
}
