using System;
using System.Windows.Forms;
using TekManager.Code.Connection;
using TekManager.DataService;

namespace TekManager.Forms
{
    public partial class EditMember : Form
    {
        private readonly MemberSqlModel _memberDetails;
        private readonly Action _refresh;
        private readonly DataServiceHelper _serviceHelper;
        public EditMember(MemberSqlModel memberDetails, Action refresh)
        {
            InitializeComponent();
            _refresh = refresh;
            _memberDetails = memberDetails;
            _serviceHelper = new DataServiceHelper();
        }

        private void EditMember_Load(object sender, System.EventArgs e)
        {
            IdLabel.Text += _memberDetails.Id.ToString();
            emailTextBox.Text = _memberDetails.Email;
            statusBox.Text = StatusToText(_memberDetails.Status);
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            var updatedMemberDetails = _memberDetails;

            if (_memberDetails.Status == statusBox.Text[0].ToString())
            {
                MessageBox.Show("No values updated");
                return;
            }


            updatedMemberDetails.Status = statusBox.Text[0].ToString();
            _serviceHelper.UpdateMember(updatedMemberDetails)
                .Match(rows =>
                {
                    if (rows == 0)
                    {
                        MessageBox.Show("no rows were updated");
                    }
                    else
                    {
                        _refresh();
                        Close();
                    }
                }, error =>
                {
                    MessageBox.Show($"Failed to save member.{Environment.NewLine}{error}");
                });
        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {

        }

        private string StatusToText(string status)
        {
            switch (status)
            {
                case "A":
                    return "Active";
                case "B":
                    return "Banned";
                default:
                    return "";
            }
        }
    }
}
