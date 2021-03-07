using System.Collections.Generic;

namespace TekManager.Code.EbayScraper
{
    public class EbayInitialScrapeData
    {
        public List<EbayItem> Items { get; set; }
        public int NumberResults { get; set; }
    }
}
