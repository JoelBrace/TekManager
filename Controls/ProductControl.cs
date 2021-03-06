using System;
using System.Drawing;
using System.Windows.Forms;
using TekManager.Code.Connection;
using TekManager.DataService;

namespace TekManager.Controls
{
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
        }

        private void ProductControl_Load(object sender, EventArgs e)
        {
            productsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            productsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            chId.Width = 30;
            chName.Width = 120;
        }

        private void DisplayProducts(string term, int count)
        {
            productsListView.Items.Clear();
            var serviceHelper = new DataServiceHelper();
            serviceHelper.GetProductsByPartial(term, count)
                .Match(onSuccess: products =>
                {
                    foreach (var product in products)
                    {
                        var row = new string[] { product.Id.ToString(), product.Name, product.Category, product.Stock.ToString(), product.Active.ToString(), product.BuyPrice.ToString(), product.SellPrice.ToString(), product.AveragePrice.ToString(),product.ImageUrl };
                        var lvi = new ListViewItem(row) {Tag = product};

                        if (product.Stock == 0)
                        {
                            lvi.BackColor = Color.DarkOrange;
                        }

                        if (product.Active == false)
                        {
                            lvi.BackColor = Color.IndianRed;
                        }

                        productsListView.Items.Add(lvi);
                    }
                }, onFailure: error =>
                {
                    MessageBox.Show($"Error: {Environment.NewLine}{error}");
                });
        }

        private void ProductSearchButton_Click(object sender, EventArgs e)
        {
            var count = 0;
            try
            {
                count = Int32.Parse(CountTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error retrieving count. Make sure it is a number.");
                return;
            }


            DisplayProducts(SearchTextBox.Text, count);
        }

        private void productsListView_MouseDoubleClick(object sender, EventArgs e)
        {
            var selectedItem = (ProductSqlModel) productsListView.SelectedItems[0].Tag;
        }
    }
}
