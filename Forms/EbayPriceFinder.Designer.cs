
using System.Security.Principal;
using System.Windows.Forms;

namespace TekManager.Forms
{
    partial class EbayPriceFinder
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.MinPriceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxPriceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.EbayResultsListView = new System.Windows.Forms.ListView();
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chImageUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PagesTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.BuyPriceLabel = new System.Windows.Forms.Label();
            this.SellPriceLabel = new System.Windows.Forms.Label();
            this.AvgPriceLabel = new System.Windows.Forms.Label();
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
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(79, 15);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(133, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // MinPriceTextBox
            // 
            this.MinPriceTextBox.Location = new System.Drawing.Point(494, 14);
            this.MinPriceTextBox.Name = "MinPriceTextBox";
            this.MinPriceTextBox.Size = new System.Drawing.Size(47, 20);
            this.MinPriceTextBox.TabIndex = 3;
            this.MinPriceTextBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Min Price";
            // 
            // MaxPriceTextBox
            // 
            this.MaxPriceTextBox.Location = new System.Drawing.Point(628, 13);
            this.MaxPriceTextBox.Name = "MaxPriceTextBox";
            this.MaxPriceTextBox.Size = new System.Drawing.Size(47, 20);
            this.MaxPriceTextBox.TabIndex = 5;
            this.MaxPriceTextBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(556, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min Price";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(218, 14);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EbayResultsListView
            // 
            this.EbayResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitle,
            this.chPrice,
            this.chImageUrl});
            this.EbayResultsListView.FullRowSelect = true;
            this.EbayResultsListView.HideSelection = false;
            this.EbayResultsListView.Location = new System.Drawing.Point(17, 60);
            this.EbayResultsListView.MultiSelect = false;
            this.EbayResultsListView.Name = "EbayResultsListView";
            this.EbayResultsListView.Size = new System.Drawing.Size(660, 345);
            this.EbayResultsListView.TabIndex = 7;
            this.EbayResultsListView.UseCompatibleStateImageBehavior = false;
            this.EbayResultsListView.View = System.Windows.Forms.View.Details;
            this.EbayResultsListView.KeyUp += new KeyEventHandler(this.EbayResultsListView_KeyUp);
            // 
            // chTitle
            // 
            this.chTitle.Text = "Title";
            // 
            // chPrice
            // 
            this.chPrice.Text = "Price";
            // 
            // chImageUrl
            // 
            this.chImageUrl.Text = "Image URL";
            // 
            // PagesTextBox
            // 
            this.PagesTextBox.Location = new System.Drawing.Point(353, 13);
            this.PagesTextBox.Name = "PagesTextBox";
            this.PagesTextBox.Size = new System.Drawing.Size(47, 20);
            this.PagesTextBox.TabIndex = 9;
            this.PagesTextBox.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pages";
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Location = new System.Drawing.Point(20, 408);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(45, 13);
            this.ResultsLabel.TabIndex = 10;
            this.ResultsLabel.Text = "Results:";
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.Location = new System.Drawing.Point(20, 41);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(54, 13);
            this.LoadingLabel.TabIndex = 11;
            this.LoadingLabel.Text = "Loading...";
            this.LoadingLabel.Visible = false;
            // 
            // BuyPriceLabel
            // 
            this.BuyPriceLabel.AutoSize = true;
            this.BuyPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyPriceLabel.Location = new System.Drawing.Point(162, 416);
            this.BuyPriceLabel.Name = "BuyPriceLabel";
            this.BuyPriceLabel.Size = new System.Drawing.Size(79, 20);
            this.BuyPriceLabel.TabIndex = 12;
            this.BuyPriceLabel.Text = "Buy Price:";
            // 
            // SellPriceLabel
            // 
            this.SellPriceLabel.AutoSize = true;
            this.SellPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellPriceLabel.Location = new System.Drawing.Point(441, 416);
            this.SellPriceLabel.Name = "SellPriceLabel";
            this.SellPriceLabel.Size = new System.Drawing.Size(78, 20);
            this.SellPriceLabel.TabIndex = 13;
            this.SellPriceLabel.Text = "Sell Price:";
            // 
            // AvgPriceLabel
            // 
            this.AvgPriceLabel.AutoSize = true;
            this.AvgPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvgPriceLabel.Location = new System.Drawing.Point(301, 416);
            this.AvgPriceLabel.Name = "AvgPriceLabel";
            this.AvgPriceLabel.Size = new System.Drawing.Size(79, 20);
            this.AvgPriceLabel.TabIndex = 14;
            this.AvgPriceLabel.Text = "Avg Price:";
            // 
            // EbayPriceFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.AvgPriceLabel);
            this.Controls.Add(this.SellPriceLabel);
            this.Controls.Add(this.BuyPriceLabel);
            this.Controls.Add(this.LoadingLabel);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.PagesTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EbayResultsListView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MaxPriceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MinPriceTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EbayPriceFinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ebay Price Finder";
            this.Load += new System.EventHandler(this.EbayPriceFinder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox MinPriceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaxPriceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListView EbayResultsListView;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.ColumnHeader chImageUrl;
        private System.Windows.Forms.TextBox PagesTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.Label LoadingLabel;
        private System.Windows.Forms.Label BuyPriceLabel;
        private System.Windows.Forms.Label SellPriceLabel;
        private System.Windows.Forms.Label AvgPriceLabel;
    }
}