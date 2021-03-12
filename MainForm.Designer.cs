
using TekManager.Controls;

namespace TekManager
{
    partial class MainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BlogButton = new System.Windows.Forms.Button();
            this.MemberProductRequestsTabButton = new System.Windows.Forms.Button();
            this.PaymentsTabButton = new System.Windows.Forms.Button();
            this.CurrentPageLabel = new System.Windows.Forms.Label();
            this.TekManagerLabel = new System.Windows.Forms.Label();
            this.LogViewerTabButton = new System.Windows.Forms.Button();
            this.MembersTabButton = new System.Windows.Forms.Button();
            this.ProductTabButton = new System.Windows.Forms.Button();
            this.logViewerControl = new TekManager.Controls.LogViewerControl();
            this.memberControl = new TekManager.Controls.MemberControl();
            this.sellRequestsControl = new TekManager.Controls.SellRequestsControl();
            this.paymentsControl = new TekManager.Controls.PaymentsControl();
            this.productControl = new TekManager.Controls.ProductControl();
            this.blogControl = new TekManager.Controls.BlogControl();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BlogButton);
            this.panel2.Controls.Add(this.MemberProductRequestsTabButton);
            this.panel2.Controls.Add(this.PaymentsTabButton);
            this.panel2.Controls.Add(this.CurrentPageLabel);
            this.panel2.Controls.Add(this.TekManagerLabel);
            this.panel2.Controls.Add(this.LogViewerTabButton);
            this.panel2.Controls.Add(this.MembersTabButton);
            this.panel2.Controls.Add(this.ProductTabButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 1017);
            this.panel2.TabIndex = 1;
            // 
            // BlogButton
            // 
            this.BlogButton.Location = new System.Drawing.Point(4, 582);
            this.BlogButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BlogButton.Name = "BlogButton";
            this.BlogButton.Size = new System.Drawing.Size(273, 80);
            this.BlogButton.TabIndex = 7;
            this.BlogButton.Text = "Blog Posts";
            this.BlogButton.UseVisualStyleBackColor = true;
            this.BlogButton.Click += new System.EventHandler(this.BlogButton_Click);
            // 
            // MemberProductRequestsTabButton
            // 
            this.MemberProductRequestsTabButton.Location = new System.Drawing.Point(4, 403);
            this.MemberProductRequestsTabButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemberProductRequestsTabButton.Name = "MemberProductRequestsTabButton";
            this.MemberProductRequestsTabButton.Size = new System.Drawing.Size(273, 80);
            this.MemberProductRequestsTabButton.TabIndex = 6;
            this.MemberProductRequestsTabButton.Text = "Sell Requests";
            this.MemberProductRequestsTabButton.UseVisualStyleBackColor = true;
            this.MemberProductRequestsTabButton.Click += new System.EventHandler(this.MemberProductRequestsTabButton_Click);
            // 
            // PaymentsTabButton
            // 
            this.PaymentsTabButton.Location = new System.Drawing.Point(4, 314);
            this.PaymentsTabButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PaymentsTabButton.Name = "PaymentsTabButton";
            this.PaymentsTabButton.Size = new System.Drawing.Size(273, 80);
            this.PaymentsTabButton.TabIndex = 5;
            this.PaymentsTabButton.Text = "Payments";
            this.PaymentsTabButton.UseVisualStyleBackColor = true;
            this.PaymentsTabButton.Click += new System.EventHandler(this.PaymentsTabButton_Click);
            // 
            // CurrentPageLabel
            // 
            this.CurrentPageLabel.AutoSize = true;
            this.CurrentPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPageLabel.Location = new System.Drawing.Point(16, 68);
            this.CurrentPageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentPageLabel.Name = "CurrentPageLabel";
            this.CurrentPageLabel.Size = new System.Drawing.Size(91, 37);
            this.CurrentPageLabel.TabIndex = 4;
            this.CurrentPageLabel.Text = "Page";
            // 
            // TekManagerLabel
            // 
            this.TekManagerLabel.AutoSize = true;
            this.TekManagerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TekManagerLabel.Location = new System.Drawing.Point(16, 12);
            this.TekManagerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TekManagerLabel.Name = "TekManagerLabel";
            this.TekManagerLabel.Size = new System.Drawing.Size(205, 37);
            this.TekManagerLabel.TabIndex = 3;
            this.TekManagerLabel.Text = "TekManager:";
            // 
            // LogViewerTabButton
            // 
            this.LogViewerTabButton.Location = new System.Drawing.Point(4, 492);
            this.LogViewerTabButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogViewerTabButton.Name = "LogViewerTabButton";
            this.LogViewerTabButton.Size = new System.Drawing.Size(273, 80);
            this.LogViewerTabButton.TabIndex = 2;
            this.LogViewerTabButton.Text = "Log Viewer";
            this.LogViewerTabButton.UseVisualStyleBackColor = true;
            this.LogViewerTabButton.Click += new System.EventHandler(this.LogViewerTabButton_Click);
            // 
            // MembersTabButton
            // 
            this.MembersTabButton.Location = new System.Drawing.Point(4, 225);
            this.MembersTabButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MembersTabButton.Name = "MembersTabButton";
            this.MembersTabButton.Size = new System.Drawing.Size(273, 80);
            this.MembersTabButton.TabIndex = 1;
            this.MembersTabButton.Text = "Members";
            this.MembersTabButton.UseVisualStyleBackColor = true;
            this.MembersTabButton.Click += new System.EventHandler(this.MembersTabButton_Click);
            // 
            // ProductTabButton
            // 
            this.ProductTabButton.Location = new System.Drawing.Point(4, 135);
            this.ProductTabButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductTabButton.Name = "ProductTabButton";
            this.ProductTabButton.Size = new System.Drawing.Size(273, 80);
            this.ProductTabButton.TabIndex = 0;
            this.ProductTabButton.Text = "Products";
            this.ProductTabButton.UseVisualStyleBackColor = true;
            this.ProductTabButton.Click += new System.EventHandler(this.ProductTabButton_Click);
            // 
            // logViewerControl
            // 
            this.logViewerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logViewerControl.Location = new System.Drawing.Point(284, 0);
            this.logViewerControl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.logViewerControl.Name = "logViewerControl";
            this.logViewerControl.Size = new System.Drawing.Size(1342, 1017);
            this.logViewerControl.TabIndex = 8;
            // 
            // memberControl
            // 
            this.memberControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberControl.Location = new System.Drawing.Point(284, 0);
            this.memberControl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.memberControl.Name = "memberControl";
            this.memberControl.Size = new System.Drawing.Size(1342, 1017);
            this.memberControl.TabIndex = 7;
            // 
            // sellRequestsControl
            // 
            this.sellRequestsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sellRequestsControl.Location = new System.Drawing.Point(284, 0);
            this.sellRequestsControl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.sellRequestsControl.Name = "sellRequestsControl";
            this.sellRequestsControl.Size = new System.Drawing.Size(1342, 1017);
            this.sellRequestsControl.TabIndex = 6;
            // 
            // paymentsControl
            // 
            this.paymentsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentsControl.Location = new System.Drawing.Point(284, 0);
            this.paymentsControl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.paymentsControl.Name = "paymentsControl";
            this.paymentsControl.Size = new System.Drawing.Size(1342, 1017);
            this.paymentsControl.TabIndex = 5;
            // 
            // productControl
            // 
            this.productControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productControl.Location = new System.Drawing.Point(284, 0);
            this.productControl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.productControl.Name = "productControl";
            this.productControl.Size = new System.Drawing.Size(1342, 1017);
            this.productControl.TabIndex = 2;
            // 
            // blogControl
            // 
            this.blogControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blogControl.Location = new System.Drawing.Point(284, 0);
            this.blogControl.Name = "blogControl";
            this.blogControl.Size = new System.Drawing.Size(1342, 1017);
            this.blogControl.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 1017);
            this.Controls.Add(this.blogControl);
            this.Controls.Add(this.logViewerControl);
            this.Controls.Add(this.memberControl);
            this.Controls.Add(this.sellRequestsControl);
            this.Controls.Add(this.paymentsControl);
            this.Controls.Add(this.productControl);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TekManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LogViewerTabButton;
        private System.Windows.Forms.Button MembersTabButton;
        private System.Windows.Forms.Button ProductTabButton;
        private ProductControl productControl;
        private System.Windows.Forms.Label TekManagerLabel;
        private System.Windows.Forms.Label CurrentPageLabel;
        private System.Windows.Forms.Button PaymentsTabButton;
        private System.Windows.Forms.Button MemberProductRequestsTabButton;
        private PaymentsControl paymentsControl;
        private SellRequestsControl sellRequestsControl;
        private MemberControl memberControl;
        private LogViewerControl logViewerControl;
        private System.Windows.Forms.Button BlogButton;
        private BlogControl blogControl;
    }
}

