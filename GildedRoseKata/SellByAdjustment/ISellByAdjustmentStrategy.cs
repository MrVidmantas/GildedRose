using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata
{
    public interface ISellByAdjustmentStrategy
    {
        void AdjustSellByDate(Item item);
    }
}
