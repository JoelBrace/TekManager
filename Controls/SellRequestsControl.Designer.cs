
namespace TekManager.Controls
{
    partial class SellRequestsControl
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.productRequestsSearchButton = new System.Windows.Forms.Button();
            this.existingRequestListView = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMemberId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatusReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newRequestListview = new System.Windows.Forms.ListView();
            this.chIdNew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMemberIdNew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProductNameNew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQualityNew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatusNew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatusReasonNew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateTimeNew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescriptionNew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 494);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "product requests";
            // 
            // productRequestsSearchButton
            // 
            this.productRequestsSearchButton.Location = new System.Drawing.Point(328, 15);
            this.productRequestsSearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.productRequestsSearchButton.Name = "productRequestsSearchButton";
            this.productRequestsSearchButton.Size = new System.Drawing.Size(136, 68);
            this.productRequestsSearchButton.TabIndex = 19;
            this.productRequestsSearchButton.Text = "Search";
            this.productRequestsSearchButton.UseVisualStyleBackColor = true;
            this.productRequestsSearchButton.Click += new System.EventHandler(this.productRequestsSearchButton_Click);
            // 
            // existingRequestListView
            // 
            this.existingRequestListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chMemberId,
            this.chProductId,
            this.chQuality,
            this.chStatus,
            this.chStatusReason,
            this.chDateTime,
            this.chDescription});
            this.existingRequestListView.FullRowSelect = true;
            this.existingRequestListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.existingRequestListView.Location = new System.Drawing.Point(26, 132);
            this.existingRequestListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.existingRequestListView.Name = "existingRequestListView";
            this.existingRequestListView.Size = new System.Drawing.Size(1286, 407);
            this.existingRequestListView.TabIndex = 18;
            this.existingRequestListView.UseCompatibleStateImageBehavior = false;
            this.existingRequestListView.View = System.Windows.Forms.View.Details;
            this.existingRequestListView.DoubleClick += new System.EventHandler(this.existingRequestListView_DoubleClick);
            // 
            // chId
            // 
            this.chId.Text = "Id";
            // 
            // chMemberId
            // 
            this.chMemberId.Text = "Member Id";
            this.chMemberId.Width = 111;
            // 
            // chProductId
            // 
            this.chProductId.Text = "Product Id";
            this.chProductId.Width = 95;
            // 
            // chQuality
            // 
            this.chQuality.Text = "Quality";
            this.chQuality.Width = 105;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 83;
            // 
            // chStatusReason
            // 
            this.chStatusReason.Text = "Status Reason";
            // 
            // chDateTime
            // 
            this.chDateTime.Text = "Date Time";
            // 
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.Width = 234;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(26, 57);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(274, 26);
            this.SearchTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Search (Member Id)";
            // 
            // newRequestListview
            // 
            this.newRequestListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIdNew,
            this.chMemberIdNew,
            this.chProductNameNew,
            this.chQualityNew,
            this.chStatusNew,
            this.chStatusReasonNew,
            this.chDateTimeNew,
            this.chDescriptionNew});
            this.newRequestListview.FullRowSelect = true;
            this.newRequestListview.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.newRequestListview.Location = new System.Drawing.Point(25, 585);
            this.newRequestListview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newRequestListview.Name = "newRequestListview";
            this.newRequestListview.Size = new System.Drawing.Size(1286, 407);
            this.newRequestListview.TabIndex = 20;
            this.newRequestListview.UseCompatibleStateImageBehavior = false;
            this.newRequestListview.View = System.Windows.Forms.View.Details;
            this.newRequestListview.DoubleClick += new System.EventHandler(this.newRequestListview_DoubleClick);
            // 
            // chIdNew
            // 
            this.chIdNew.Text = "Id";
            // 
            // chMemberIdNew
            // 
            this.chMemberIdNew.Text = "Member Id";
            this.chMemberIdNew.Width = 107;
            // 
            // chProductNameNew
            // 
            this.chProductNameNew.Text = "Product Name";
            this.chProductNameNew.Width = 139;
            // 
            // chQualityNew
            // 
            this.chQualityNew.Text = "Quality";
            // 
            // chStatusNew
            // 
            this.chStatusNew.Text = "Status";
            // 
            // chStatusReasonNew
            // 
            this.chStatusReasonNew.Text = "Status Reason";
            // 
            // chDateTimeNew
            // 
            this.chDateTimeNew.Text = "Date Time";
            // 
            // chDescriptionNew
            // 
            this.chDescriptionNew.Text = "Description";
            this.chDescriptionNew.Width = 180;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Existing Product Requests";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 551);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "New Product Requests";
            // 
            // SellRequestsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newRequestListview);
            this.Controls.Add(this.productRequestsSearchButton);
            this.Controls.Add(this.existingRequestListView);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SellRequestsControl";
            this.Size = new System.Drawing.Size(1341, 1017);
            this.Load += new System.EventHandler(this.ProductRequestsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button productRequestsSearchButton;
        private System.Windows.Forms.ListView existingRequestListView;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView newRequestListview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chMemberId;
        private System.Windows.Forms.ColumnHeader chProductId;
        private System.Windows.Forms.ColumnHeader chQuality;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.ColumnHeader chIdNew;
        private System.Windows.Forms.ColumnHeader chMemberIdNew;
        private System.Windows.Forms.ColumnHeader chProductNameNew;
        private System.Windows.Forms.ColumnHeader chQualityNew;
        private System.Windows.Forms.ColumnHeader chStatusNew;
        private System.Windows.Forms.ColumnHeader chDescriptionNew;
        private System.Windows.Forms.ColumnHeader chDateTime;
        private System.Windows.Forms.ColumnHeader chDateTimeNew;
        private System.Windows.Forms.ColumnHeader chStatusReason;
        private System.Windows.Forms.ColumnHeader chStatusReasonNew;
    }
}
