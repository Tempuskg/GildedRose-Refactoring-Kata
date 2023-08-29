namespace GildedRoseKata.Goods;

internal class AgedBrie : GoodBase
{
    public AgedBrie(Item item) : base(item)
    {
    }

    public override void DegradeQuality()
    {
        if (Quality < 50)
        {
            Quality++;
        }

        SellIn--;

        if (SellIn >= 0) return;
        
        if (Quality < 50)
        {
            Quality++;
        }
    }
}
