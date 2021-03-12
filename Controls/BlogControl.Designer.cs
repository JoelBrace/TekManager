
namespace TekManager.Controls
{
    partial class BlogControl
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
            this.BlogSearchButton = new System.Windows.Forms.Button();
            this.blogsListView = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newPostButton = new System.Windows.Forms.Button();
            this.deleteBlogPostButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BlogSearchButton
            // 
            this.BlogSearchButton.Location = new System.Drawing.Point(486, 20);
            this.BlogSearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BlogSearchButton.Name = "BlogSearchButton";
            this.BlogSearchButton.Size = new System.Drawing.Size(136, 68);
            this.BlogSearchButton.TabIndex = 19;
            this.BlogSearchButton.Text = "Search";
            this.BlogSearchButton.UseVisualStyleBackColor = true;
            this.BlogSearchButton.Click += new System.EventHandler(this.BlogSearchButton_Click);
            // 
            // blogsListView
            // 
            this.blogsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chDateTime,
            this.chTitle,
            this.chContent});
            this.blogsListView.FullRowSelect = true;
            this.blogsListView.HideSelection = false;
            this.blogsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.blogsListView.Location = new System.Drawing.Point(26, 111);
            this.blogsListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blogsListView.MultiSelect = false;
            this.blogsListView.Name = "blogsListView";
            this.blogsListView.Size = new System.Drawing.Size(1286, 878);
            this.blogsListView.TabIndex = 18;
            this.blogsListView.UseCompatibleStateImageBehavior = false;
            this.blogsListView.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "Id";
            // 
            // chDateTime
            // 
            this.chDateTime.Text = "Date Time";
            // 
            // chTitle
            // 
            this.chTitle.Text = "Title";
            // 
            // chContent
            // 
            this.chContent.Text = "Content";
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
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search (Title or Content)";
            // 
            // newPostButton
            // 
            this.newPostButton.Location = new System.Drawing.Point(630, 20);
            this.newPostButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPostButton.Name = "newPostButton";
            this.newPostButton.Size = new System.Drawing.Size(136, 68);
            this.newPostButton.TabIndex = 20;
            this.newPostButton.Text = "New Post";
            this.newPostButton.UseVisualStyleBackColor = true;
            this.newPostButton.Click += new System.EventHandler(this.newPostButton_Click);
            // 
            // deleteBlogPostButton
            // 
            this.deleteBlogPostButton.Location = new System.Drawing.Point(774, 20);
            this.deleteBlogPostButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteBlogPostButton.Name = "deleteBlogPostButton";
            this.deleteBlogPostButton.Size = new System.Drawing.Size(136, 68);
            this.deleteBlogPostButton.TabIndex = 21;
            this.deleteBlogPostButton.Text = "Delete Post";
            this.deleteBlogPostButton.UseVisualStyleBackColor = true;
            this.deleteBlogPostButton.Click += new System.EventHandler(this.deleteBlogPostButton_Click);
            // 
            // BlogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteBlogPostButton);
            this.Controls.Add(this.newPostButton);
            this.Controls.Add(this.BlogSearchButton);
            this.Controls.Add(this.blogsListView);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label1);
            this.Name = "BlogControl";
            this.Size = new System.Drawing.Size(1341, 1017);
            this.Load += new System.EventHandler(this.BlogControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BlogSearchButton;
        private System.Windows.Forms.ListView blogsListView;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.ColumnHeader chContent;
        private System.Windows.Forms.ColumnHeader chDateTime;
        private System.Windows.Forms.Button newPostButton;
        private System.Windows.Forms.Button deleteBlogPostButton;
    }
}
