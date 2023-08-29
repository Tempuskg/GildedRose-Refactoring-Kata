namespace GildedRoseKata.Goods;

public class BackStageTAFKAL80ETC : GoodBase
{
    public BackStageTAFKAL80ETC(Item item) : base(item)
    {
    }

    public override void DegradeQuality()
    {
        if (Quality < 50)
        {
            Quality++;

            if (SellIn < 11)
            {
                if (Quality < 50)
                {
                    Quality++;
                }
            }

            if (SellIn < 6)
            {
                if (Quality < 50)
                {
                    Quality++;
                }
            }
        }

        SellIn--;

        if (SellIn < 0)
        {

            Quality -= Quality;

        }
    }
}