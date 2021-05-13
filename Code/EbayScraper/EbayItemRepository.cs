using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using HtmlAgilityPack;
using ScrapySharp.Extensions;

namespace TekManager.Code.EbayScraper
{
    public class EbayItemRepository
    {
        private readonly EbayScraper _scraper;

        public EbayItemRepository()
        {
            _scraper = new EbayScraper();
        }

        public EbayInitialScrapeData GetItems(string searchName, int numPages = 5, int lowPrice = 0, int highPrice = 0)
        {
            var initialScrapeData = InitialGetItemByName(searchName, lowPrice, highPrice);

            var numPagesAvailable = initialScrapeData.NumberResults / 200 + 1;

            var currentPage = 2;

            while (currentPage <= numPages && currentPage <= numPagesAvailable)
            {
                Thread.Sleep(1500);
                initialScrapeData.Items.AddRange(GetItemsByPage(searchName, lowPrice, highPrice, currentPage));

                currentPage++;
            }

            return initialScrapeData;
        }

        private List<EbayItem> GetItemsByPage(string searchName, int lowPrice, int highPrice, int page)
        {
            var htmlNode = _scraper.GetHtml(searchName, page, lowPrice, highPrice);

            var htmlItems = htmlNode.CssSelect("li.s-item").ToList();
            htmlItems.RemoveAt(0);

            return NodesToItemsMapper(htmlItems);

        }

        private EbayInitialScrapeData InitialGetItemByName(string searchName, int lowPrice, int highPrice)
        {
            var htmlNode = _scraper.GetHtml(searchName, 1, lowPrice, highPrice);

            var htmlItems = htmlNode.CssSelect("li.s-item").ToList();
            htmlItems.RemoveAt(0);

            var htmlResultCount = htmlNode.CssSelect("h1.srp-controls__count-heading").ToList();

            var resultCount = Convert.ToInt32(htmlResultCount.First().InnerText.Split(' ')[0].Replace(",", ""));

            return new EbayInitialScrapeData()
            {
                Items = NodesToItemsMapper(htmlItems),
                NumberResults = resultCount
            };

        }

        private List<EbayItem> NodesToItemsMapper(List<HtmlNode> itemNodes)
        {
            var items = new List<EbayItem>();

            foreach (var htmlItem in itemNodes)
            {

                var name = htmlItem.CssSelect("h3.s-item__title").First().InnerText;
                var priceHtml = htmlItem.CssSelect(".s-item__price").First().InnerText;

                var imageUrl = htmlItem.CssSelect("img.s-item__image-img").First().GetAttributeValue("src");
                var url = htmlItem.CssSelect("div.s-item__image").First().FirstChild.GetAttributeValue("href");

                var prices = priceHtml.Split(' ');

                var priceList = new List<string>();

                if (prices.Length > 1)
                {
                    priceList.Add(prices[0]);
                    priceList.Add(prices[2]);
                }
                else
                {
                    priceList.Add(prices[0]);
                }

                priceList = priceList.Select(price => price.Replace("?", "")).ToList();
                priceList = priceList.Select(price => price.Replace("£", "")).ToList();

                items.Add(new EbayItem(name, priceList.Select(Convert.ToDecimal).ToList(), imageUrl, url));
            }

            return items;
        }
    }
}
