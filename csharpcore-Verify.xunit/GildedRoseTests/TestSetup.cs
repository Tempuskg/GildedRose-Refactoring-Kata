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
}