using System;
using System.Collections.Generic;

namespace TekManager.Code.EbayScraper
{
    public class EbayItem
    {
        public string Name { get; set; }
        public List<decimal> Price { get; set; }
        public string ImageUrl { get; set; }

        public EbayItem(string name, List<decimal> price, string imageUrl)
        {
            Name = name;
            Price = price;
            ImageUrl = imageUrl;
        }
    }
}
