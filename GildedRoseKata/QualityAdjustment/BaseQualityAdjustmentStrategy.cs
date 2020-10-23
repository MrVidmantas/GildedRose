using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.QualityAdjustment
{
    public abstract class BaseQualityAdjustmentStrategy : IQualityAdjustmentStrategy
    {
        public void AdjustQuality(Item item)
        {
            var startingQuality = item.Quality;

            CustomBehaviour(item);

            var postConfigureQuality = item.Quality;

            if (item.Quality < 0)
            {
                item.Quality = 0;
            }

            if (item.Quality > 50 && startingQuality != postConfigureQuality)
            {
                item.Quality = 50;
            }
        }

        protected abstract void CustomBehaviour(Item item);

    }
}
