using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TekManager.Code.EbayScraper;

namespace TekManager.Forms
{
    public partial class EbayPriceFinder : Form
    {

        delegate void UpdateListViewCallback(List<EbayItem> ebayItems);

        delegate void LoadingTextStateCallback(bool state);

        delegate void ResultsTextCallback(string numberResults);

        delegate void BuyPriceTextCallback(string buyPrice);
        delegate void SellPriceTextCallback(string sellPrice);
        delegate void AvgPriceTextCallback(string avgPrice);

        public EbayPriceFinder()
        {
            InitializeComponent();
        }

        private void EbayPriceFinder_Load(object sender, EventArgs e)
        {
            chImageUrl.Width = 200;
            chTitle.Width = 300;
            chPrice.Width = 50;
        }

        public void UpdateListView(List<EbayItem> ebayItems)
        {
            if (EbayResultsListView.InvokeRequired)
            {
                UpdateListViewCallback d = UpdateListView;
                Invoke(d, ebayItems);
            }
            else
            {
                foreach (var ebayItem in ebayItems)
                {
                    var row = new string[] {ebayItem.Name, ebayItem.Price.Average().ToString(), ebayItem.ImageUrl};
                    var lvi = new ListViewItem(row) {Tag = ebayItem};

                    EbayResultsListView.Items.Add(lvi);
                }
            }
        }

        public void LoadingTextState(bool state)
        {
            if (LoadingLabel.InvokeRequired)
            {
                LoadingTextStateCallback d = LoadingTextState;
                Invoke(d, state);
            }
            else
            {
                LoadingLabel.Visible = state;
            }
        }

        public void ResultsText(string text)
        {
            if (ResultsLabel.InvokeRequired)
            {
                ResultsTextCallback d = ResultsText;
                Invoke(d, text);
            }
            else
            {
                ResultsLabel.Text = text;
            }
        }

        public void BuyPriceText(string text)
        {
            if (BuyPriceLabel.InvokeRequired)
            {
                BuyPriceTextCallback d = BuyPriceText;
                Invoke(d, text);
            }
            else
            {
                BuyPriceLabel.Text = text;
            }
        }
        public void SellPriceText(string text)
        {
            if (SellPriceLabel.InvokeRequired)
            {
                SellPriceTextCallback d = SellPriceText;
                Invoke(d, text);
            }
            else
            {
                SellPriceLabel.Text = text;
            }
        }
        public void AvgPriceText(string text)
        {
            if (AvgPriceLabel.InvokeRequired)
            {
                AvgPriceTextCallback d = AvgPriceText;
                Invoke(d, text);
            }
            else
            {
                AvgPriceLabel.Text = text;
            }
        }



        private void SearchButton_Click(object sender, EventArgs e)
        {
            var minPrice = 0;
            var maxPrice = 0;
            var pages = 0;

            if (NameTextBox.Text.Length < 2)
            {
                MessageBox.Show("Search term must be more than 2 characters");
                return;
            }

            try
            {
                minPrice = Convert.ToInt32(MinPriceTextBox.Text);
                maxPrice = Convert.ToInt32(MaxPriceTextBox.Text);
                pages = Convert.ToInt32(PagesTextBox.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Failed to parse values, please input numbers.");
                return;
            }

            EbayResultsListView.Items.Clear();
            Task.Run(() => SearchEbay(NameTextBox.Text, minPrice, maxPrice, pages));
        }

        private void SearchEbay(string searchTerm, int minPrice, int maxPrice, int pages)
        {
            LoadingTextState(true);
            var ebayItemRepository = new EbayItemRepository();

            var data = ebayItemRepository.GetItems(searchTerm, pages, minPrice, maxPrice);

            var items = data.Items.OrderBy(item => item.Price.Average()).ToList();

            var average =
                EbayStatsProvider.CalculateWeightedAverage(items.Select(item => item.Price.First()).ToList());

            var buy = average * 1.25m;
            var sell = average * 0.75m;

            UpdateListView(items);
            ResultsText($"Results: {items.Count} of {data.NumberResults}");
            BuyPriceText($"Buy Price: {Math.Round(buy, 2)}");
            SellPriceText($"Sell Price: {Math.Round(sell, 2)}");
            AvgPriceText($"Avg Price: {Math.Round(average, 2)}");
            LoadingTextState(false);
        }

        private void EbayResultsListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender != EbayResultsListView) return;

            if (e.Control && e.KeyCode == Keys.C)
                CopySelectedValuesToClipboard();
        }

        private void CopySelectedValuesToClipboard()
        {
            var builder = new StringBuilder();
            foreach (ListViewItem item in EbayResultsListView.SelectedItems)
                builder.AppendLine(item.SubItems[2].Text);

            Clipboard.SetText(builder.ToString());
        }
    }
}
