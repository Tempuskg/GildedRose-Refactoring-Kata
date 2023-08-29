using System.Collections.Generic;
using FluentAssertions;
using GildedRoseKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRoseTests.Goods
{
    [TestClass]
    public class WhenUsingASulfuras
    {
        [DataTestMethod]
        [TestCategory("Unit")]
        [DataRow(11, 1, 0, DisplayName = "Sulfuras Sellin 11 and Quality 1")]
        [DataRow(11, 0, 0, DisplayName = "Sulfuras Sellin 11 and Quality 0")]
        [DataRow(-1, 1, 0, DisplayName = "Sulfuras Sellin -1 and Quality 1")]
        public void Items_should_degrade_as_expected(int sellin, int quality, int expectedQualityChange)
        {
            var item = TestSetup.ASulfurasItem();
            item.Quality = quality;
            item.SellIn  = sellin;
            IList<Item> items            = new List<Item> { item };
            var         app              = new GildedRose(items);
            var         beginningQuality = item.Quality;

            app.UpdateQuality();

            var degradedAmount = beginningQuality - item.Quality;
            degradedAmount.Should().Be(expectedQualityChange);
        }


        [TestMethod]
        [TestCategory("Unit")]
        public void The_name_property_should_be_Sulfuras_Hand_of_Ragnaros()
        {
            var good = Good.Create(TestSetup.ASulfurasItem());

            good.Name.Should().Be("Sulfuras, Hand of Ragnaros");
        }

    }
}
