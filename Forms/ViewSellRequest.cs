using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TekFront.Code.Option.Result;
using TekManager.Code.Connection;
using TekManager.DataService;

namespace TekManager.Forms
{
    public partial class ViewSellRequest : Form
    {
        private readonly SellRequestSqlModel _requestDetails;
        private readonly Action _refresh;
        private readonly DataServiceHelper _serviceHelper;

        public ViewSellRequest(SellRequestSqlModel requestDetails, Action refresh)
        {
            InitializeComponent();
            _refresh = refresh;
            _requestDetails = requestDetails;
            _serviceHelper = new DataServiceHelper();
        }

        private void ViewSellRequest_Load(object sender, EventArgs e)
        {
            IdLabel.Text += _requestDetails.Id.ToString();
            memberIdLabel.Text += _requestDetails.MemberId.ToString();

            if (_requestDetails.ProductId == 0)
            {
                productIdLabel.Text += "N/a";
            }
            else
            {
                productIdLabel.Text += _requestDetails.ProductId.ToString();

            }

            if (_requestDetails.ProductName == null)
            {
                _serviceHelper.GetProducts(_requestDetails.ProductId.ToString())
                    .Match(product =>
                    {
                        productNameLabel.Text += product.First().Name;
                    }, error =>
                    {
                        productNameLabel.Text += "N/a";
                    });
            }
            else
            {
                productNameLabel.Text += _requestDetails.ProductName;
            }

            qualityLabel.Text += _requestDetails.Quality;
            dateTimeLabel.Text += _requestDetails.DateTime.ToString();
            descriptionTextBox.Text += Regex.Replace(_requestDetails.Description, "(.{60})", "$1\n");
            statusComboBox.Text = StatusToText(_requestDetails.Status);

            if (_requestDetails.Status == "P")
            {
                reasonTextBox.Enabled = false;
            }

            reasonTextBox.Text = _requestDetails.StatusReason;


        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var updateSellRequestUpdate = new UpdateSellRequestDto()
            {
                SellRequestId = _requestDetails.Id,
                Status = statusComboBox.Text[0].ToString(),
                StatusReason = reasonTextBox.Text
            };

            if (updateSellRequestUpdate.Status == _requestDetails.Status
                && updateSellRequestUpdate.StatusReason == _requestDetails.StatusReason)
            {
                Close();
                return;
            }


            _serviceHelper.UpdateSellRequestStatusAndReason(updateSellRequestUpdate)
                .Match(rows =>
                {
                    if (rows == 0)
                    {
                        MessageBox.Show("Row was not updated.");
                    }
                    else
                    {
                        if (updateSellRequestUpdate.Status == "D" || updateSellRequestUpdate.Status == "A")
                        {
                            var confirmResult = MessageBox.Show("Do you want to send a sell request update to the member?",
                                "Send Email",
                                MessageBoxButtons.YesNo);

                            if (confirmResult == DialogResult.Yes)
                            {
                                _serviceHelper.SendSellRequestUpdateEmail(updateSellRequestUpdate.SellRequestId)
                                    .MatchFailure(error => { MessageBox.Show($"Failed to send email.{Environment.NewLine}{error}"); });
                            }
                        }

                        _refresh();
                        Close();
                    }
                }, error =>
                {
                    MessageBox.Show(error);
                });
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            reasonTextBox.Enabled = statusComboBox.Text[0] != 'P';
        }

        private void imagesButton_Click(object sender, EventArgs e)
        {
            var imageViewPopup = new ViewSellRequestImages(_requestDetails.Id);
            imageViewPopup.Show();
        }

        private string StatusToText(string status)
        {
            switch (status)
            {
                case "P":
                    return "Pending";
                case "D":
                    return "Denied";
                case "A":
                    return "Accepted";
                case "F":
                    return "Finished";
                default:
                    return "";
            }
        }
    }
}
