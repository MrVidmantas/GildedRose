using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.SellByAdjustment
{
    public static class SellByAdjustmentStrategyFactory
    {
        public static ISellByAdjustmentStrategy CreateSellByAdjustmentStrategy(string itemName)
        {
            if (itemName.Contains("Sulfuras"))
            {
                return new SulfurasSellByAdjustmentStrategy();
            }

            return new DefaultSellByAdjustmentStrategy();
        }
    }
}
