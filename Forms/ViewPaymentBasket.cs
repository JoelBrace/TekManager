using System;
using System.Windows.Forms;
using TekManager.Code.Connection;

namespace TekManager.Forms
{
    public partial class ViewPaymentBasket : Form
    {
        private readonly DataServiceHelper _serviceHelper;
        private readonly int _paymentId;
        public ViewPaymentBasket(int paymentId)
        {
            InitializeComponent();
            _paymentId = paymentId;
            _serviceHelper = new DataServiceHelper();
        }

        private void ViewPaymentBasket_Load(object sender, EventArgs e)
        {
            PaymentBasketListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            PaymentBasketListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            chId.Width = 30;
            chProductQuantity.Width -= 100;
            chProductPrice.Width = 70;

            _serviceHelper.GetPaymentBasketByPaymentId(_paymentId)
                .Match(onSuccess: paymentBaskets =>
                {
                    foreach (var paymentBasket in paymentBaskets)
                    {
                        var row = new string[] { paymentBasket.Id.ToString(), paymentBasket.PaymentId.ToString(), paymentBasket.ProductId.ToString(), paymentBasket.Name, $"£{paymentBasket.ProductPrice}", paymentBasket.ProductQuantity.ToString()  };
                        var lvi = new ListViewItem(row) { Tag = paymentBasket };


                        PaymentBasketListView.Items.Add(lvi);
                    }
                    PaymentBasketListView.Items.RemoveAt(0);
                }, onFailure: error =>
                {
                    MessageBox.Show($"Error: {Environment.NewLine}{error}");
                    Close();
                });
        }
    }
}
