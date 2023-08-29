namespace GildedRoseKata;

public class BackStageTAFKAL80ETC : Good
{
    private readonly Item _item;

    public BackStageTAFKAL80ETC(Item item)
    {
        _item = item;
    }

    public override string Name => _item.Name;
}