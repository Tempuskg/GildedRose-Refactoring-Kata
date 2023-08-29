namespace GildedRoseKata.Goods;

public class Sulfuras : Good
{
    public Sulfuras(Item item) : base(item)
    {
    }

    public override void DegradeQuality()
    {
        //Sulfuras doesn't degrade
    }
}