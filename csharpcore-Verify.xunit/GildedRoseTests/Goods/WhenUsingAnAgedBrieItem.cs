using System.Collections.Generic;
using FluentAssertions;
using GildedRoseKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRoseTests.Goods
{
    [TestClass]
    public class WhenUsingAnAgedBrieItem
    {
        [TestMethod]
        [TestCategory("Unit")]
        public void AgedBrie_items_should_increase_quality_by_1()
        {
            var anAgedBrieItem = TestSetup.AnAgedBrieItem();
            anAgedBrieItem.Quality = 1;
            IList<Item> items = new List<Item> { anAgedBrieItem};
            var app = new GildedRose(items);
            var beginningQuality = anAgedBrieItem.Quality;
            
            app.UpdateQuality();

            var degradedAmount = beginningQuality - anAgedBrieItem.Quality;
            degradedAmount.Should().Be(-1);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void AgedBrie_items_with_sellin_less_than_or_equal_to_0_should_increase_quality_by_2()
        {
            var anAgedBrieItem = TestSetup.AnAgedBrieItem();
            anAgedBrieItem.Quality = 1;
            anAgedBrieItem.SellIn  = 0;
            IList<Item> items            = new List<Item> { anAgedBrieItem };
            var         app              = new GildedRose(items);
            var         beginningQuality = anAgedBrieItem.Quality;

            app.UpdateQuality();

            var degradedAmount = beginningQuality - anAgedBrieItem.Quality;
            degradedAmount.Should().Be(-2);
        }

    }
}
