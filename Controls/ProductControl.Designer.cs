
namespace TekManager.Controls
{
    partial class ProductControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.productsListView = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBuyPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSellPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAveragePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chImageUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductSearchButton = new System.Windows.Forms.Button();
            this.ProductAddButton = new System.Windows.Forms.Button();
            this.chActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(17, 37);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(184, 20);
            this.SearchTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Count";
            // 
            // CountTextBox
            // 
            this.CountTextBox.Location = new System.Drawing.Point(222, 37);
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(83, 20);
            this.CountTextBox.TabIndex = 3;
            this.CountTextBox.Text = "100";
            // 
            // productsListView
            // 
            this.productsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chName,
            this.chCategory,
            this.chStock,
            this.chActive,
            this.chBuyPrice,
            this.chSellPrice,
            this.chAveragePrice,
            this.chImageUrl});
            this.productsListView.FullRowSelect = true;
            this.productsListView.HideSelection = false;
            this.productsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.productsListView.Location = new System.Drawing.Point(17, 72);
            this.productsListView.Name = "productsListView";
            this.productsListView.Size = new System.Drawing.Size(859, 572);
            this.productsListView.TabIndex = 4;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            this.productsListView.View = System.Windows.Forms.View.Details;
            this.productsListView.DoubleClick += new System.EventHandler(this.productsListView_MouseDoubleClick);
            // 
            // chId
            // 
            this.chId.Text = "Id";
            // 
            // chName
            // 
            this.chName.Text = "Name";
            // 
            // chCategory
            // 
            this.chCategory.Text = "Category";
            // 
            // chStock
            // 
            this.chStock.Text = "Stock";
            // 
            // chBuyPrice
            // 
            this.chBuyPrice.Text = "Buy Price";
            // 
            // chSellPrice
            // 
            this.chSellPrice.Text = "Sell Price";
            // 
            // chAveragePrice
            // 
            this.chAveragePrice.Text = "Average Price";
            // 
            // chImageUrl
            // 
            this.chImageUrl.Text = "Image URL";
            // 
            // ProductSearchButton
            // 
            this.ProductSearchButton.Location = new System.Drawing.Point(324, 13);
            this.ProductSearchButton.Name = "ProductSearchButton";
            this.ProductSearchButton.Size = new System.Drawing.Size(91, 44);
            this.ProductSearchButton.TabIndex = 5;
            this.ProductSearchButton.Text = "Search";
            this.ProductSearchButton.UseVisualStyleBackColor = true;
            this.ProductSearchButton.Click += new System.EventHandler(this.ProductSearchButton_Click);
            // 
            // ProductAddButton
            // 
            this.ProductAddButton.Location = new System.Drawing.Point(421, 13);
            this.ProductAddButton.Name = "ProductAddButton";
            this.ProductAddButton.Size = new System.Drawing.Size(90, 44);
            this.ProductAddButton.TabIndex = 6;
            this.ProductAddButton.Text = "Add Product";
            this.ProductAddButton.UseVisualStyleBackColor = true;
            // 
            // chActive
            // 
            this.chActive.Text = "Active";
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProductAddButton);
            this.Controls.Add(this.ProductSearchButton);
            this.Controls.Add(this.productsListView);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(894, 661);
            this.Load += new System.EventHandler(this.ProductControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.ListView productsListView;
        private System.Windows.Forms.Button ProductSearchButton;
        private System.Windows.Forms.Button ProductAddButton;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chCategory;
        private System.Windows.Forms.ColumnHeader chBuyPrice;
        private System.Windows.Forms.ColumnHeader chSellPrice;
        private System.Windows.Forms.ColumnHeader chAveragePrice;
        private System.Windows.Forms.ColumnHeader chImageUrl;
        private System.Windows.Forms.ColumnHeader chStock;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chActive;
    }
}
