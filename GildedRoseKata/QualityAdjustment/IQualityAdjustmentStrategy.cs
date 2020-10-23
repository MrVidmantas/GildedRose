using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public interface IQualityAdjustmentStrategy
    {
        void AdjustQuality(Item item);
    }
}
