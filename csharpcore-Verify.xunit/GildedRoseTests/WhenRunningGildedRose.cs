using System.Collections.Generic;
using FluentAssertions;
using GildedRoseKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRoseTests
{
    [TestClass]
    public class WhenRunningGildedRose
    {
        [TestMethod]
        [TestCategory("Unit")]
        public void It_should_not_change_items_list_order()
        {
            IList<Item> items = new List<Item> { TestSetup.ARegularItem() };
            var         app   = new GildedRose(items);
            app.UpdateQuality();
            items[0].Name.Should().Be("foo");
        }

        
    }
}
