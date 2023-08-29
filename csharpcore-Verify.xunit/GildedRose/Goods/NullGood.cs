namespace GildedRoseKata.Goods;

public class NullGood : Good
{


    public override string Name => string.Empty;

    public NullGood(Item item) : base(item)
    {
    }
}