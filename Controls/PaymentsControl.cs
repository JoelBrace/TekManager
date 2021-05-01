using System;
using System.Drawing;
using System.Windows.Forms;
using TekManager.Code.Connection;
using TekManager.DataService;
using TekManager.Forms;

namespace TekManager.Controls
{
    public partial class PaymentsControl : UserControl
    {
        public PaymentsControl()
        {
            InitializeComponent();
        }

        private void PaymentsControl_Load(object sender, EventArgs e)
        {
            PaymentsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            PaymentsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            chId.Width = 30;
            chPaymentTime.Width = 120;
        }

        private void paymentSearchButton_Click(object sender, EventArgs e)
        {
            RefreshPayments();
        }

        private void DisplayPayments(string searchTerm, int count)
        {
            PaymentsListView.Items.Clear();
            var serviceHelper = new DataServiceHelper();
            serviceHelper.GetPaymentsByMemberIdSearch(searchTerm, count)
                .Match(onSuccess: payments =>
                {
                    foreach (var payment in payments)
                    {
                        var row = new string[] { payment.Id.ToString(), payment.MemberId.ToString(), payment.PaymentMethod, payment.PaymentTime.ToString(), $"£{payment.TotalCost}", payment.BillingAddress };
                        var lvi = new ListViewItem(row) { Tag = payment };


                        PaymentsListView.Items.Add(lvi);
                    }
                }, onFailure: error =>
                {
                    MessageBox.Show($"Error: {Environment.NewLine}{error}");
                });
        }

        private void RefreshPayments()
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


            DisplayPayments(SearchTextBox.Text, count);
        }

        private void PaymentsListView_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = (PaymentSqlModel)PaymentsListView.SelectedItems[0].Tag;

            var newBlogPostPopup = new ViewPaymentBasket(selectedItem.Id);
            newBlogPostPopup.Show(this);
        }
    }
}
