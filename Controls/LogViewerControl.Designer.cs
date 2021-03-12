
namespace TekManager.Controls
{
    partial class LogViewerControl
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
            this.logViewerSearchButton = new System.Windows.Forms.Button();
            this.logsListView = new System.Windows.Forms.ListView();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chLogId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // logViewerSearchButton
            // 
            this.logViewerSearchButton.Location = new System.Drawing.Point(486, 20);
            this.logViewerSearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logViewerSearchButton.Name = "logViewerSearchButton";
            this.logViewerSearchButton.Size = new System.Drawing.Size(136, 68);
            this.logViewerSearchButton.TabIndex = 19;
            this.logViewerSearchButton.Text = "Search";
            this.logViewerSearchButton.UseVisualStyleBackColor = true;
            this.logViewerSearchButton.Click += new System.EventHandler(this.logViewerSearchButton_Click);
            // 
            // logsListView
            // 
            this.logsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLogId,
            this.chDateTime,
            this.chMessage});
            this.logsListView.FullRowSelect = true;
            this.logsListView.HideSelection = false;
            this.logsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.logsListView.Location = new System.Drawing.Point(26, 111);
            this.logsListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logsListView.Name = "logsListView";
            this.logsListView.Size = new System.Drawing.Size(1286, 878);
            this.logsListView.TabIndex = 18;
            this.logsListView.UseCompatibleStateImageBehavior = false;
            this.logsListView.View = System.Windows.Forms.View.Details;
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
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search (Message)";
            // 
            // chLogId
            // 
            this.chLogId.Text = "Id";
            // 
            // chDateTime
            // 
            this.chDateTime.Text = "Date Time";
            // 
            // chMessage
            // 
            this.chMessage.Text = "Message";
            // 
            // LogViewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logViewerSearchButton);
            this.Controls.Add(this.logsListView);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogViewerControl";
            this.Size = new System.Drawing.Size(1341, 1017);
            this.Load += new System.EventHandler(this.LogViewerControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logViewerSearchButton;
        private System.Windows.Forms.ListView logsListView;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader chLogId;
        private System.Windows.Forms.ColumnHeader chDateTime;
        private System.Windows.Forms.ColumnHeader chMessage;
    }
}
