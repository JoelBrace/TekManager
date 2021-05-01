
namespace TekManager.Controls
{
    partial class PaymentsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.paymentSearchButton = new System.Windows.Forms.Button();
            this.PaymentsListView = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chMemberId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPaymentMethod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPaymentTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBillingAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotalCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // paymentSearchButton
            // 
            this.paymentSearchButton.Location = new System.Drawing.Point(486, 20);
            this.paymentSearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paymentSearchButton.Name = "paymentSearchButton";
            this.paymentSearchButton.Size = new System.Drawing.Size(136, 68);
            this.paymentSearchButton.TabIndex = 19;
            this.paymentSearchButton.Text = "Search";
            this.paymentSearchButton.UseVisualStyleBackColor = true;
            this.paymentSearchButton.Click += new System.EventHandler(this.paymentSearchButton_Click);
            // 
            // PaymentsListView
            // 
            this.PaymentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chMemberId,
            this.chPaymentMethod,
            this.chPaymentTime,
            this.chTotalCost,
            this.chBillingAddress});
            this.PaymentsListView.FullRowSelect = true;
            this.PaymentsListView.HideSelection = false;
            this.PaymentsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.PaymentsListView.Location = new System.Drawing.Point(26, 111);
            this.PaymentsListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PaymentsListView.Name = "PaymentsListView";
            this.PaymentsListView.Size = new System.Drawing.Size(1286, 878);
            this.PaymentsListView.TabIndex = 18;
            this.PaymentsListView.UseCompatibleStateImageBehavior = false;
            this.PaymentsListView.View = System.Windows.Forms.View.Details;
            this.PaymentsListView.DoubleClick += new System.EventHandler(this.PaymentsListView_DoubleClick);
            // 
            // chId
            // 
            this.chId.Text = "Id";
            this.chId.Width = 55;
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(333, 57);
            this.CountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(122, 26);
            this.CountTextBox.TabIndex = 17;
            this.CountTextBox.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Count";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(26, 57);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(274, 26);
            this.SearchTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search (Member Id)";
            // 
            // chMemberId
            // 
            this.chMemberId.Text = "Member Id";
            this.chMemberId.Width = 118;
            // 
            // chPaymentMethod
            // 
            this.chPaymentMethod.Text = "Payment Method";
            this.chPaymentMethod.Width = 146;
            // 
            // chPaymentTime
            // 
            this.chPaymentTime.Text = "Payment Time";
            this.chPaymentTime.Width = 128;
            // 
            // chBillingAddress
            // 
            this.chBillingAddress.Text = "Billing Address";
            this.chBillingAddress.Width = 129;
            // 
            // chTotalCost
            // 
            this.chTotalCost.Text = "Total Cost";
            this.chTotalCost.Width = 117;
            // 
            // PaymentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paymentSearchButton);
            this.Controls.Add(this.PaymentsListView);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PaymentsControl";
            this.Size = new System.Drawing.Size(1341, 1017);
            this.Load += new System.EventHandler(this.PaymentsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button paymentSearchButton;
        private System.Windows.Forms.ListView PaymentsListView;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader chMemberId;
        private System.Windows.Forms.ColumnHeader chPaymentMethod;
        private System.Windows.Forms.ColumnHeader chPaymentTime;
        private System.Windows.Forms.ColumnHeader chTotalCost;
        private System.Windows.Forms.ColumnHeader chBillingAddress;
    }
}
