using System;
using System.Windows.Forms;
using TekManager.Code.Connection;
using TekManager.DataService;

namespace TekManager.Forms
{
    public partial class AddProduct : Form
    {
        private readonly Action _refresh;
        public AddProduct(Action refresh)
        {
            _refresh = refresh;
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }


            var avgPrice = Convert.ToDecimal(AveragePriceTextbox.Text);
            var buyPrice = Convert.ToDecimal(BuyPriceTextBox.Text);
            var sellPrice = Convert.ToDecimal(SellPriceTextBox.Text);
            var stock = Convert.ToInt32(StockTextBox.Text);

            var addProduct = new ProductSqlModel()
            {
                Active = ActiveCheckBox.Checked,
                AveragePrice = avgPrice,
                BuyPrice = buyPrice,
                SellPrice = sellPrice,
                Category = CategoryComboBox.Text,
                Id = 0,
                ImageUrl = ImageUrlTextBox.Text,
                ExtensionData = null,
                Name = NameTextBox.Text,
                Stock = stock
            };

            var serviceHelper = new DataServiceHelper();
            serviceHelper.SaveProduct(addProduct)
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

        private bool ValidateFields()
        {
            var NameEmpty = NameTextBox.Text == "";
            var CategoryEmpty = CategoryComboBox.Text == "";
            var AvgEmpty = AveragePriceTextbox.Text == "";
            var BuyEmpty = BuyPriceTextBox.Text == "";
            var SellEmpty = SellPriceTextBox.Text == "";
            var StockEmpty = StockTextBox.Text == "";

            return  !(NameEmpty || CategoryEmpty || AvgEmpty || BuyEmpty || SellEmpty || StockEmpty);
        }
    }
}
