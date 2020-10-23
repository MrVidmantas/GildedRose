using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public class DefaultSellByAdjustmentStrategy : ISellByAdjustmentStrategy
    {
        public void AdjustSellByDate(Item item)
        {
            item.SellIn--;
        }
    }
}
