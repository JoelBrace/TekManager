
namespace TekManager.Forms
{
    partial class ViewPaymentBasket
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.PaymentBasketListView = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPaymentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProductId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProductQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // PaymentBasketListView
            // 
            this.PaymentBasketListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chPaymentId,
            this.chProductId,
            this.chProductName,
            this.chProductPrice,
            this.chProductQuantity});
            this.PaymentBasketListView.FullRowSelect = true;
            this.PaymentBasketListView.HideSelection = false;
            this.PaymentBasketListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.PaymentBasketListView.Location = new System.Drawing.Point(13, 14);
            this.PaymentBasketListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PaymentBasketListView.Name = "PaymentBasketListView";
            this.PaymentBasketListView.Size = new System.Drawing.Size(961, 437);
            this.PaymentBasketListView.TabIndex = 13;
            this.PaymentBasketListView.UseCompatibleStateImageBehavior = false;
            this.PaymentBasketListView.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "Id";
            this.chId.Width = 64;
            // 
            // chPaymentId
            // 
            this.chPaymentId.Text = "Payment Id";
            this.chPaymentId.Width = 116;
            // 
            // chProductId
            // 
            this.chProductId.Text = "Product Id";
            this.chProductId.Width = 147;
            // 
            // chProductPrice
            // 
            this.chProductPrice.Text = "Price";
            this.chProductPrice.Width = 71;
            // 
            // chProductQuantity
            // 
            this.chProductQuantity.Text = "Quantity";
            this.chProductQuantity.Width = 105;
            // 
            // chProductName
            // 
            this.chProductName.Text = "Product Name";
            // 
            // ViewPaymentBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 472);
            this.Controls.Add(this.PaymentBasketListView);
            this.Name = "ViewPaymentBasket";
            this.Text = "View Payment Basket";
            this.Load += new System.EventHandler(this.ViewPaymentBasket_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView PaymentBasketListView;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chPaymentId;
        private System.Windows.Forms.ColumnHeader chProductPrice;
        private System.Windows.Forms.ColumnHeader chProductQuantity;
        private System.Windows.Forms.ColumnHeader chProductId;
        private System.Windows.Forms.ColumnHeader chProductName;
    }
}