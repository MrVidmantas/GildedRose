using System.Collections.Generic;
using GildedRoseKata.QualityAdjustment;
using GildedRoseKata.SellByAdjustment;

namespace GildedRoseKata
{
    public class GildedRose
    {
        readonly IList<Item> _items;

        public GildedRose(IList<Item> Items)
        {
            _items = Items;
        }

        public void UpdateFuckingEverything()
        {
            foreach (var item in _items)
            {
                var qualityAdjustmentStrategy =
                    QualityAdjustmentStrategyFactory.CreateQualityAdjustmentStrategy(item.Name);

                var sellByAdjustmentStrategy =
                    SellByAdjustmentStrategyFactory.CreateSellByAdjustmentStrategy(item.Name);

                sellByAdjustmentStrategy.AdjustSellByDate(item);
                qualityAdjustmentStrategy.AdjustQuality(item);
            }
        }
    }
}
