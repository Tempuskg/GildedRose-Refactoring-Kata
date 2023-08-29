using GildedRoseKata.Goods;

namespace GildedRoseKata;

public class Conjured : GoodBase
{
    public Conjured(Item item) : base(item)
    {
    }

    public override void DegradeQuality()
    {
        NormalGood.DegradeQualityWithRate(this, NormalGood.DegradeRate*2);
    }
}