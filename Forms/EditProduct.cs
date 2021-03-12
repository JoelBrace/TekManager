using System;
using System.Windows.Forms;
using TekManager.Code.Connection;
using TekManager.DataService;

namespace TekManager.Forms
{
    public partial class EditProduct : Form
    {
        private readonly ProductSqlModel _productSqlModel;
        private readonly Action _refresh;
        private readonly DataServiceHelper _serviceHelper;
        public EditProduct(ProductSqlModel productDetails, Action refresh)
        {
            InitializeComponent();
            _refresh = refresh;
            _productSqlModel = productDetails;
            _serviceHelper = new DataServiceHelper();
        }

        private void EditProduct_Load(object sender, System.EventArgs e)
        {
            ProductIdLabel.Text += _productSqlModel.Id;
            NameTextBox.Text = _productSqlModel.Name;
            CategoryComboBox.Text = _productSqlModel.Category;
            AveragePriceTextbox.Text = _productSqlModel.AveragePrice.ToString();
            BuyPriceTextBox.Text = _productSqlModel.BuyPrice.ToString();
            SellPriceTextBox.Text = _productSqlModel.SellPrice.ToString();
            StockTextBox.Text = _productSqlModel.Stock.ToString();
            ImageUrlTextBox.Text = _productSqlModel.ImageUrl;
            ActiveCheckBox.Checked = _productSqlModel.Active;
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            if (!ValuesUpdated())
            {
                MessageBox.Show("No values updated");
                return;
            };


            var avgPrice = Convert.ToDecimal(AveragePriceTextbox.Text);
            var buyPrice = Convert.ToDecimal(BuyPriceTextBox.Text);
            var sellPrice = Convert.ToDecimal(SellPriceTextBox.Text);
            var stock = Convert.ToInt32(StockTextBox.Text);

            var updatedProduct = new ProductSqlModel()
            {
                Active = ActiveCheckBox.Checked,
                AveragePrice = avgPrice,
                BuyPrice = buyPrice,
                SellPrice = sellPrice,
                Category = CategoryComboBox.Text,
                Id = _productSqlModel.Id,
                ImageUrl = ImageUrlTextBox.Text,
                ExtensionData = null,
                Name = NameTextBox.Text,
                Stock = stock
            };

            _serviceHelper.SaveProduct(updatedProduct)
                .Match(onSuccess: rows =>
                {
                    if (rows == 0) 
                    {
                        MessageBox.Show("No rows were updated!");
                    }
                    else
                    {
                        _refresh();
                        Close();
                    }
                }, onFailure: error =>
                {
                    MessageBox.Show($"Error:{Environment.NewLine}{error}");
                });
        }

        private bool ValuesUpdated()
        {
            var IdUpdated = ProductIdLabel.Text.Split(':')[1].TrimStart() != _productSqlModel.Id.ToString();
            var NameUpdated = NameTextBox.Text != _productSqlModel.Name;
            var CategoryUpdated = CategoryComboBox.Text != _productSqlModel.Category;
            var AvgUpdated = AveragePriceTextbox.Text != _productSqlModel.AveragePrice.ToString();
            var BuyUpdated = BuyPriceTextBox.Text != _productSqlModel.BuyPrice.ToString();
            var SellUpdated = SellPriceTextBox.Text != _productSqlModel.SellPrice.ToString();
            var StockUpdated = StockTextBox.Text != _productSqlModel.Stock.ToString();
            var ImageUrlUpdated = ImageUrlTextBox.Text != _productSqlModel.ImageUrl;
            var ActiveUpdated = ActiveCheckBox.Checked != _productSqlModel.Active;

            return IdUpdated || NameUpdated || CategoryUpdated || AvgUpdated || BuyUpdated || SellUpdated || StockUpdated ||
                   ImageUrlUpdated || ActiveUpdated;


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete {_productSqlModel.Name}?",
                    "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.No) return;


            _serviceHelper.DeleteProduct(_productSqlModel.Id)
                .Match(onSuccess: rows =>
                {
                    if (rows == 0)
                    {
                        MessageBox.Show("No rows were updated!");
                    }
                    else
                    {
                        _refresh();
                        Close();
                    }
                }, onFailure: error =>
                {
                    MessageBox.Show($"Error:{Environment.NewLine}{error}");
                }); ;

        }
    }
}
