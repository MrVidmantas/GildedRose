using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.QualityAdjustment
{
    public static class QualityAdjustmentStrategyFactory
    {
        public static IQualityAdjustmentStrategy CreateQualityAdjustmentStrategy(string itemName)
        {
            if (itemName == "Aged Brie")
            {
                return new AgedBrieQualityAdjustmentStrategy();
            }

            if (itemName.Contains("Sulfuras"))
            {
                return new SulfurasQualityAdjustmentStrategy();
            }

            if (itemName.Contains("Backstage pass"))
            {
                return new BackstagePassQualityAdjustmentStrategy();
            }

            if (itemName.Contains("Conjured"))
            {
                return new ConjuredItemQualityAdjustmentStrategy();
            }

            return new DefaultQualityAdjustmentStrategy();
        }
    }
}
