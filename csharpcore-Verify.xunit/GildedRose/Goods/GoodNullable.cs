using System;

namespace GildedRoseKata.Goods;

public class GoodNullable : Good
{
    private readonly Item _item;

    public GoodNullable(Item item)
    {
        _item = item;
    }

    public override string Name => string.Empty;
}