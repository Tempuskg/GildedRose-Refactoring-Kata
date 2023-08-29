using System.Collections.Generic;
using FluentAssertions;
using GildedRoseKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRoseTests.Goods
{
    [TestClass]
    public class WhenUsingABackStageTAFKAL80ETC
    {
        [DataTestMethod]
        [TestCategory("Unit")]
        [DataRow(11, 50, 0,  DisplayName = "Sellin 11 and Quality 50")]
        [DataRow(10, 50, 0,  DisplayName = "Sellin 10 and Quality 50")]
        [DataRow(11, 49, -1, DisplayName = "Sellin 11 and Quality 49")]
        [DataRow(10, 49, -1, DisplayName = "Sellin 10 and Quality 49")]
        [DataRow(11, 48, -1, DisplayName = "Sellin 11 and Quality 48")]
        [DataRow(10, 48, -2, DisplayName = "Sellin 10 and Quality 48")]
        [DataRow(6,  50, 0,  DisplayName = "Sellin 6 and Quality 50")]
        [DataRow(5,  50, 0,  DisplayName = "Sellin 5 and Quality 50")]
        [DataRow(6,  49, -1, DisplayName = "Sellin 6 and Quality 49")]
        [DataRow(5,  49, -1, DisplayName = "Sellin 5 and Quality 49")]
        [DataRow(6,  48, -2, DisplayName = "Sellin 6 and Quality 48")]
        [DataRow(5,  48, -2, DisplayName = "Sellin 5 and Quality 48")]
        [DataRow(6,  47, -2, DisplayName = "Sellin 6 and Quality 47")]
        [DataRow(5,  47, -3, DisplayName = "Sellin 5 and Quality 47")]
        [DataRow(0,  47, 47, DisplayName = "Sellin 0 and Quality 47")]
        public void Conjured_items_should_degrade_twice_as_fast_as_normal_items(int sellin, int quality, int expectedQualityChange)
        {
            var item = TestSetup.ABackStageTAFKAL80ETCItem();
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
        public void The_name_property_should_be_Backstage_passes_to_a_TAFKAL80ETC_concert()
        {
            var agedBrie = Good.Create(TestSetup.ABackStageTAFKAL80ETCItem());

            agedBrie.Name.Should().Be("Backstage passes to a TAFKAL80ETC concert");
        }

    }
}
