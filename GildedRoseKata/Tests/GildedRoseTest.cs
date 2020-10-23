using System.Collections.Generic;
using Xunit;

namespace GildedRoseKata
{
    public class GildedRoseTest
    {
        [Fact]
        public void UpdateQualityTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateFuckingEverything();
            Assert.Equal("foo", Items[0].Name);
            Assert.Equal(-1, Items[0].SellIn);
        }
    }
}