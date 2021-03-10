using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TekFront.Code.Option.Result;
using TekManager.Code.Connection;
using TekManager.DataService;
using TekManager.Forms;

namespace TekManager.Controls
{
    public partial class SellRequestsControl : UserControl
    {
        public SellRequestsControl()
        {
            InitializeComponent();
        }

        private void ProductRequestsControl_Load(object sender, EventArgs e)
        {
            newRequestListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            newRequestListview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            existingRequestListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            existingRequestListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            chDateTime.Width = 120;
            chDateTimeNew.Width = 120;
            chDescription.Width -= 60;
            chDescriptionNew.Width -= 60;
        }

        private void productRequestsSearchButton_Click(object sender, EventArgs e)
        {
            RefreshProductRequests();
        }

        private void RefreshProductRequests()
        {
            var memberId = 0;
            try
            {
                memberId = Int32.Parse(SearchTextBox.Text);
            }
            catch (Exception)
            {
                // ignored
            }


            DisplayProducts(memberId);
        }

        private void DisplayProducts(int memberId)
        {
            existingRequestListView.Items.Clear();
            newRequestListview.Items.Clear();

            var serviceHelper = new DataServiceHelper();

            Result<List<SellRequestSqlModel>> result = null;

            result = memberId == 0 ? serviceHelper.GetAllSellRequests() : serviceHelper.GetSellRequestsByMemberId(memberId);


           result.Match(requests =>
                {
                    var existingItemRequests = requests.Where(request => request.ProductName==null).ToList();
                    var newItemRequests = requests.Where(request => request.ProductId == 0).ToList();

                    //existing
                    foreach (var existingItemRequest in existingItemRequests)
                    {
                        var row = new string[] { existingItemRequest.Id.ToString(), existingItemRequest.MemberId.ToString(), existingItemRequest.ProductId.ToString(), existingItemRequest.Quality, existingItemRequest.Status, existingItemRequest.StatusReason, existingItemRequest.DateTime.ToString(), existingItemRequest.Description};
                        var lvi = new ListViewItem(row) {Tag = existingItemRequest};

                        switch (existingItemRequest.Status)
                        {
                            case "P":
                                lvi.BackColor = Color.DarkOrange;
                                break;
                            case "D":
                                lvi.BackColor = Color.IndianRed;
                                break;
                            case "A":
                                lvi.BackColor = Color.Green;
                                break;
                        }

                        existingRequestListView.Items.Add(lvi);
                    }



                    //new
                    foreach (var newItemRequest in newItemRequests)
                    {
                        var row = new string[] { newItemRequest.Id.ToString(), newItemRequest.MemberId.ToString(), newItemRequest.ProductName, newItemRequest.Quality, newItemRequest.Status, newItemRequest.StatusReason, newItemRequest.DateTime.ToString(), newItemRequest.Description };
                        var lvi = new ListViewItem(row) { Tag = newItemRequest };
                        switch (newItemRequest.Status)
                        {
                            case "P":
                                lvi.BackColor = Color.DarkOrange;
                                break;
                            case "D":
                                lvi.BackColor = Color.IndianRed;
                                break;
                            case "A":
                                lvi.BackColor = Color.Green;
                                break;
                        }



                        newRequestListview.Items.Add(lvi);
                    }


                }, error =>
                {
                    MessageBox.Show($"Error: {Environment.NewLine}{error}");
                });
        }

        private void existingRequestListView_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = (SellRequestSqlModel)existingRequestListView.SelectedItems[0].Tag;
            var productAddPopup = new ViewSellRequest(selectedItem, RefreshProductRequests);
            productAddPopup.Show();
        }

        private void newRequestListview_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = (SellRequestSqlModel)newRequestListview.SelectedItems[0].Tag;
            var productAddPopup = new ViewSellRequest(selectedItem, RefreshProductRequests);
            productAddPopup.Show();
        }
    }
}
