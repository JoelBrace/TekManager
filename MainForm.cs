using System.Collections.Generic;
using System.Windows.Forms;

namespace TekManager
{
    public partial class MainForm : Form
    {
        private readonly List<UserControl> _userControls;
        public MainForm()
        {
            InitializeComponent();
            _userControls = new List<UserControl>();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            _userControls.Add(productControl);
            _userControls.Add(memberControl);
            _userControls.Add(paymentsControl);
            _userControls.Add(logViewerControl);
            _userControls.Add(productRequestsControl);

            ShowControl(productControl);
            CurrentPageLabel.Text = "Products";
        }

        private void ProductTabButton_Click(object sender, System.EventArgs e)
        {
            ShowControl(productControl, sender);
        }

        private void MembersTabButton_Click(object sender, System.EventArgs e)
        {
            ShowControl(memberControl, sender);
        }

        private void PaymentsTabButton_Click(object sender, System.EventArgs e)
        {
            ShowControl(paymentsControl, sender);
        }

        private void LogViewerTabButton_Click(object sender, System.EventArgs e)
        {
            ShowControl(logViewerControl, sender);
        }

        private void MemberProductRequestsTabButton_Click(object sender, System.EventArgs e)
        {
            ShowControl(productRequestsControl, sender);
        }

        private void ShowControl(UserControl userControl, object sender = null)
        {
            _userControls.ForEach(control => control.Hide());
            userControl.Show();
            userControl.BringToFront();

            if (sender == null) return;
            CurrentPageLabel.Text = ((Button)sender).Text;
        }
    }
}
