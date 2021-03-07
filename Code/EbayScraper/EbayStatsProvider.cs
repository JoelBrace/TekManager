using System;
using System.Collections.Generic;
using System.Linq;

namespace TekManager.Code.EbayScraper
{
    public static class EbayStatsProvider
    {
        public static decimal CalculateWeightedAverage(List<decimal> numbers)
        {
            var orderedPrices = numbers.OrderBy(number => number).ToList();

            var lowerQuartileIndex = (orderedPrices.Count + 1) / 4;
            var upperQuartileIndex = lowerQuartileIndex * 3;

            orderedPrices = orderedPrices.Skip(lowerQuartileIndex)
                .Take(upperQuartileIndex - lowerQuartileIndex).ToList();

            return orderedPrices.Sum(price => price) / orderedPrices.Count;
        }
    }
}
