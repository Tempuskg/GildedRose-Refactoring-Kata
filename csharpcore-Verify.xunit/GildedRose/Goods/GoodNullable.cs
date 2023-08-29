using System;

namespace GildedRoseKata.Goods;

public class GoodNullable : Good
{


    public override string Name => string.Empty;

    public GoodNullable(Item item) : base(item)
    {
    }
}