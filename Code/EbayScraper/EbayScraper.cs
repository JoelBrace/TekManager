using System;
using HtmlAgilityPack;
using ScrapySharp.Network;

namespace TekManager.Code.EbayScraper
{
    public class EbayScraper
    {
        private readonly ScrapingBrowser _browser;

        private const string EbayUrl = "https://www.ebay.co.uk/sch/i.html?_nkw=";
        private const string Params = "&LH_Sold=1&LH_ItemCondition=3000&LH_BIN=1&_ipg=200&_pgn=";

        public EbayScraper()
        {
            _browser = new ScrapingBrowser();
        }
        public HtmlNode GetHtml(string searchName, int page, int lowPrice, int highPrice)
        {
            searchName = searchName.Replace(' ', '+');

            var url = $"{EbayUrl}{searchName}{Params}{page}";

            if (!(lowPrice == 0 && highPrice == 0))
            {
                url += $"&_udlo={lowPrice}&_udhi={highPrice}";
            }

            var webpage = _browser.NavigateToPage(new Uri(url));
            return webpage.Html;
        }
    }
}
