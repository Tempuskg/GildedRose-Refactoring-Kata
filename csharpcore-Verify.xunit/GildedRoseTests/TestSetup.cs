using GildedRoseKata;

namespace GildedRoseTests;

public class TestSetup
{
    public static Item ARegularItem()
    {
        return new Item { Name = "foo", SellIn = 3, Quality = 6 };
    }

    public static Item AConjuredItem()
    {
        return new Item() { Name = GoodBase.Conjured, SellIn = 3, Quality = 6 };
    }

    public static Item AnAgedBrieItem()
    {
        return new Item() { Name = GoodBase.AgedBrie, SellIn = 3, Quality = 6 };
    }

    public static Item ABackStageTAFKAL80ETCItem()
    {
        return new Item() { Name = GoodBase.BackStageTAFKAL80ETC, SellIn = 15, Quality = 20 };
    }

    public static Item ASulfurasItem()
    {
        return new Item() { Name = GoodBase.Sulfuras, SellIn = 15, Quality = 20 };
    }
}