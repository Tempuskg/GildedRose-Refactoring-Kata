namespace GildedRoseKata;

internal class AgedBrie : Good
{
    private readonly Item _item;

    public AgedBrie(Item item)
    {
        _item = item;
    }

    public override string Name => _item.Name;
}