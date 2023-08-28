using System.Collections.Generic;
using GildedRoseKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Xunit.Assert;

namespace GildedRoseTests
{
    [TestClass]
    public class WhenRunningGildedRose
    {
        [TestMethod]
        [TestCategory("Unit")]
        public void It_should_not_change_items_list_order()
        {
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.Equal("foo", items[0].Name);
        }
    }
}
