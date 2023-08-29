namespace GildedRoseKata.Goods;

public class NormalGood : GoodBase
{
    public NormalGood(Item item) : base(item)
    {
    }

    public override void DegradeQuality()
    {
        if (Quality > 0)
        {
            Quality--;
        }

        SellIn--;

        if (SellIn >= 0) return;

        if (Quality > 0)
        {
            Quality--;
        }

    }
}