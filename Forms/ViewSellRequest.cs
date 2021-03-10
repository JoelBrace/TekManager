using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
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
                productNameLabel.Text += "N/a";
            }
            else
            {
                productNameLabel.Text += _requestDetails.ProductName;
            }

            qualityLabel.Text += _requestDetails.Quality;
            dateTimeLabel.Text += _requestDetails.DateTime.ToString();
            descriptionTextBox.Text += Regex.Replace(_requestDetails.Description, "(.{20})", "$1\n");
            statusComboBox.Text = _requestDetails.Status;

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
                Status = statusComboBox.Text,
                StatusReason = reasonTextBox.Text
            };


            _serviceHelper.UpdateSellRequestStatusAndReason(updateSellRequestUpdate)
                .Match(rows =>
                {
                    if (rows == 0)
                    {
                        MessageBox.Show("Row was not updated.");
                    }
                    else
                    {
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
            reasonTextBox.Enabled = statusComboBox.Text != "P";
        }
    }
}
