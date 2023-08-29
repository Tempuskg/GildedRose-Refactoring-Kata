namespace GildedRoseKata.Goods;

public class NormalGood : GoodBase
{
    public NormalGood(Item item) : base(item)
    {
    }

    public override void DegradeQuality()
    {
        DegradeQualityWithRate(this,DegradeRate);
    }

    public const int DegradeRate = 1;

    public static void DegradeQualityWithRate(GoodBase good, int degradeRate)
    {
        if (good.Quality > 0)
        {
            good.Quality -= degradeRate;
        }

        good.SellIn--;

        if (good.SellIn >= 0) return;

        if (good.Quality > 0)
        {
            good.Quality -= degradeRate;
        }
    }
}