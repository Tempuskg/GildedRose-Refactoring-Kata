using System.Collections.Generic;
using FluentAssertions;
using GildedRoseKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRoseTests.Goods
{
    [TestClass]
    public class WhenUsingAConjuredItem
    {
        [TestMethod]
        [TestCategory("Unit_NotImplemented")]
        public void Conjured_items_should_degrade_twice_as_fast_as_normal_items()
        {
            var aNormalItem = TestSetup.ARegularItem();
            var aConjuredItem = TestSetup.AConjuredItem();
            IList<Item> items = new List<Item> { aNormalItem, aConjuredItem };
            var app = new GildedRose(items);
            var normalItemBeginningQuality = aNormalItem.Quality;
            var conjuredItemBeginningQuality = aConjuredItem.Quality;

            app.UpdateQuality();

            var normalItemDegradedAmount = normalItemBeginningQuality - aNormalItem.Quality;
            var conjuredItemDegradedAmount = conjuredItemBeginningQuality - aConjuredItem.Quality;
            conjuredItemDegradedAmount.Should().Be(2 * normalItemDegradedAmount);
        }
    }
}
