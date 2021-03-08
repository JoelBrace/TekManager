
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
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // MemberSearchButton
            // 
            this.MemberSearchButton.Location = new System.Drawing.Point(324, 13);
            this.MemberSearchButton.Name = "MemberSearchButton";
            this.MemberSearchButton.Size = new System.Drawing.Size(91, 44);
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
            this.membersListView.Location = new System.Drawing.Point(17, 72);
            this.membersListView.Name = "membersListView";
            this.membersListView.Size = new System.Drawing.Size(859, 572);
            this.membersListView.TabIndex = 12;
            this.membersListView.UseCompatibleStateImageBehavior = false;
            this.membersListView.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "Id";
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
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
            this.CountTextBox.Location = new System.Drawing.Point(222, 37);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(83, 20);
            this.CountTextBox.TabIndex = 11;
            this.CountTextBox.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Count";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(17, 37);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(184, 20);
            this.SearchTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search (Id or Email)";
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            // 
            // MemberControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MemberSearchButton);
            this.Controls.Add(this.membersListView);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label1);
            this.Name = "MemberControl";
            this.Size = new System.Drawing.Size(894, 661);
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
