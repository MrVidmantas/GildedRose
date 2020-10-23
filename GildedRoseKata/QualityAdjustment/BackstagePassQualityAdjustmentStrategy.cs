using System;
using System.Collections.Generic;
using System.Text;
using GildedRoseKata.QualityAdjustment;

namespace GildedRoseKata
{
    public class BackstagePassQualityAdjustmentStrategy : BaseQualityAdjustmentStrategy
    {
        protected override void CustomBehaviour(Item item)
        {
            if (item.SellIn < 0)
            {
                item.Quality = 0;

                return;
            }

            var incrementValue = item.SellIn < 5  ? 3 : item.SellIn < 10 ? 2 : 1;

            item.Quality += incrementValue;
        }
    }
}
