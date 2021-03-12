using System;
using System.Drawing;
using System.Windows.Forms;
using TekManager.Code.Connection;

namespace TekManager.Controls
{
    public partial class LogViewerControl : UserControl
    {
        public LogViewerControl()
        {
            InitializeComponent();
        }

        private void LogViewerControl_Load(object sender, EventArgs e)
        {
            logsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            logsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            chDateTime.Width = 120;
        }

        private void logViewerSearchButton_Click(object sender, EventArgs e)
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


            RefreshLogs(SearchTextBox.Text, count);
        }

        private void RefreshLogs(string messageTerm, int count)
        {
            logsListView.Items.Clear();
            var serviceHelper = new DataServiceHelper();
            serviceHelper.GetLogsByMessage(messageTerm, count)
                .Match(onSuccess: logMessages =>
                {
                    foreach (var logMessage in logMessages)
                    {
                        var row = new string[] { logMessage.Id.ToString(), logMessage.DateTime.ToString(), logMessage.Message };
                        var lvi = new ListViewItem(row) { Tag = logMessage };

                        logsListView.Items.Add(lvi);
                    }
                }, onFailure: error =>
                {
                    MessageBox.Show($"Error: {Environment.NewLine}{error}");
                });
        }
    }
}
