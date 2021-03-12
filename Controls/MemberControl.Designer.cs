
namespace TekManager.Controls
{
    partial class MemberControl
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
            this.MemberSearchButton = new System.Windows.Forms.Button();
            this.membersListView = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MemberSearchButton
            // 
            this.MemberSearchButton.Location = new System.Drawing.Point(486, 20);
            this.MemberSearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemberSearchButton.Name = "MemberSearchButton";
            this.MemberSearchButton.Size = new System.Drawing.Size(136, 68);
            this.MemberSearchButton.TabIndex = 13;
            this.MemberSearchButton.Text = "Search";
            this.MemberSearchButton.UseVisualStyleBackColor = true;
            this.MemberSearchButton.Click += new System.EventHandler(this.MemberSearchButton_Click);
            // 
            // membersListView
            // 
            this.membersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chEmail,
            this.chStatus,
            this.chName,
            this.chPassword});
            this.membersListView.FullRowSelect = true;
            this.membersListView.HideSelection = false;
            this.membersListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.membersListView.Location = new System.Drawing.Point(26, 111);
            this.membersListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.membersListView.Name = "membersListView";
            this.membersListView.Size = new System.Drawing.Size(1286, 878);
            this.membersListView.TabIndex = 12;
            this.membersListView.UseCompatibleStateImageBehavior = false;
            this.membersListView.View = System.Windows.Forms.View.Details;
            this.membersListView.DoubleClick += new System.EventHandler(this.membersListView_DoubleClick);
            // 
            // chId
            // 
            this.chId.Text = "Id";
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            // 
            // chName
            // 
            this.chName.Text = "Name";
            // 
            // chPassword
            // 
            this.chPassword.Text = "Password";
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(333, 57);
            this.CountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(122, 26);
            this.CountTextBox.TabIndex = 11;
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
            this.label2.TabIndex = 10;
            this.label2.Text = "Count";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(26, 57);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(274, 26);
            this.SearchTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search (Id or Email)";
            // 
            // MemberControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MemberSearchButton);
            this.Controls.Add(this.membersListView);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MemberControl";
            this.Size = new System.Drawing.Size(1341, 1017);
            this.Load += new System.EventHandler(this.MemberControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MemberSearchButton;
        private System.Windows.Forms.ListView membersListView;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPassword;
        private System.Windows.Forms.ColumnHeader chStatus;
    }
}
