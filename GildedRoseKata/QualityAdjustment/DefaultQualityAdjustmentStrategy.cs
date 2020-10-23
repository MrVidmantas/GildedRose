using System;
using System.Collections.Generic;
using System.Text;
using GildedRoseKata.QualityAdjustment;

namespace GildedRoseKata
{
    public class DefaultQualityAdjustmentStrategy : BaseQualityAdjustmentStrategy
    {
        protected override void CustomBehaviour(Item item)
        {
            var decrementValue = item.SellIn < 0 ? 2 : 1;

            item.Quality -= decrementValue;
        }
    }
}
