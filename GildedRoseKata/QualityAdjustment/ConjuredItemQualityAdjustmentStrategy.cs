using System;
using System.Collections.Generic;
using System.Text;
using GildedRoseKata.QualityAdjustment;

namespace GildedRoseKata
{
    public class ConjuredItemQualityAdjustmentStrategy : BaseQualityAdjustmentStrategy
    {
        protected override void CustomBehaviour(Item item)
        {
            var decrementValue = item.SellIn < 0 ? 4 : 2;

            item.Quality -= decrementValue;
        }
    }
}
