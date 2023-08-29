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
        return new Item() { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 };
    }

    public static Item AnAgedBrieItem()
    {
        return new Item() { Name = "Aged Brie", SellIn = 3, Quality = 6 };
    }

    public static Item ABackStageTAFKAL80ETCItem()
    {
        return new Item() { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 };
    }
}