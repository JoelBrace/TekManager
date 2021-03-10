
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
            this.MemberProductRequestsTabButton = new System.Windows.Forms.Button();
            this.PaymentsTabButton = new System.Windows.Forms.Button();
            this.CurrentPageLabel = new System.Windows.Forms.Label();
            this.TekManagerLabel = new System.Windows.Forms.Label();
            this.LogViewerTabButton = new System.Windows.Forms.Button();
            this.MembersTabButton = new System.Windows.Forms.Button();
            this.ProductTabButton = new System.Windows.Forms.Button();
            this._sellRequestsControl = new TekManager.Controls.SellRequestsControl();
            this.paymentsControl = new TekManager.Controls.PaymentsControl();
            this.productControl = new TekManager.Controls.ProductControl();
            this.memberControl = new TekManager.Controls.MemberControl();
            this.logViewerControl = new TekManager.Controls.LogViewerControl();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.MemberProductRequestsTabButton);
            this.panel2.Controls.Add(this.PaymentsTabButton);
            this.panel2.Controls.Add(this.CurrentPageLabel);
            this.panel2.Controls.Add(this.TekManagerLabel);
            this.panel2.Controls.Add(this.LogViewerTabButton);
            this.panel2.Controls.Add(this.MembersTabButton);
            this.panel2.Controls.Add(this.ProductTabButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 661);
            this.panel2.TabIndex = 1;
            // 
            // MemberProductRequestsTabButton
            // 
            this.MemberProductRequestsTabButton.Location = new System.Drawing.Point(3, 262);
            this.MemberProductRequestsTabButton.Name = "MemberProductRequestsTabButton";
            this.MemberProductRequestsTabButton.Size = new System.Drawing.Size(182, 52);
            this.MemberProductRequestsTabButton.TabIndex = 6;
            this.MemberProductRequestsTabButton.Text = "Sell Requests";
            this.MemberProductRequestsTabButton.UseVisualStyleBackColor = true;
            this.MemberProductRequestsTabButton.Click += new System.EventHandler(this.MemberProductRequestsTabButton_Click);
            // 
            // PaymentsTabButton
            // 
            this.PaymentsTabButton.Location = new System.Drawing.Point(3, 204);
            this.PaymentsTabButton.Name = "PaymentsTabButton";
            this.PaymentsTabButton.Size = new System.Drawing.Size(182, 52);
            this.PaymentsTabButton.TabIndex = 5;
            this.PaymentsTabButton.Text = "Payments";
            this.PaymentsTabButton.UseVisualStyleBackColor = true;
            this.PaymentsTabButton.Click += new System.EventHandler(this.PaymentsTabButton_Click);
            // 
            // CurrentPageLabel
            // 
            this.CurrentPageLabel.AutoSize = true;
            this.CurrentPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPageLabel.Location = new System.Drawing.Point(11, 44);
            this.CurrentPageLabel.Name = "CurrentPageLabel";
            this.CurrentPageLabel.Size = new System.Drawing.Size(63, 26);
            this.CurrentPageLabel.TabIndex = 4;
            this.CurrentPageLabel.Text = "Page";
            // 
            // TekManagerLabel
            // 
            this.TekManagerLabel.AutoSize = true;
            this.TekManagerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TekManagerLabel.Location = new System.Drawing.Point(11, 8);
            this.TekManagerLabel.Name = "TekManagerLabel";
            this.TekManagerLabel.Size = new System.Drawing.Size(138, 26);
            this.TekManagerLabel.TabIndex = 3;
            this.TekManagerLabel.Text = "TekManager:";
            // 
            // LogViewerTabButton
            // 
            this.LogViewerTabButton.Location = new System.Drawing.Point(3, 320);
            this.LogViewerTabButton.Name = "LogViewerTabButton";
            this.LogViewerTabButton.Size = new System.Drawing.Size(182, 52);
            this.LogViewerTabButton.TabIndex = 2;
            this.LogViewerTabButton.Text = "Log Viewer";
            this.LogViewerTabButton.UseVisualStyleBackColor = true;
            this.LogViewerTabButton.Click += new System.EventHandler(this.LogViewerTabButton_Click);
            // 
            // MembersTabButton
            // 
            this.MembersTabButton.Location = new System.Drawing.Point(3, 146);
            this.MembersTabButton.Name = "MembersTabButton";
            this.MembersTabButton.Size = new System.Drawing.Size(182, 52);
            this.MembersTabButton.TabIndex = 1;
            this.MembersTabButton.Text = "Members";
            this.MembersTabButton.UseVisualStyleBackColor = true;
            this.MembersTabButton.Click += new System.EventHandler(this.MembersTabButton_Click);
            // 
            // ProductTabButton
            // 
            this.ProductTabButton.Location = new System.Drawing.Point(3, 88);
            this.ProductTabButton.Name = "ProductTabButton";
            this.ProductTabButton.Size = new System.Drawing.Size(182, 52);
            this.ProductTabButton.TabIndex = 0;
            this.ProductTabButton.Text = "Products";
            this.ProductTabButton.UseVisualStyleBackColor = true;
            this.ProductTabButton.Click += new System.EventHandler(this.ProductTabButton_Click);
            // 
            // _sellRequestsControl
            // 
            this._sellRequestsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sellRequestsControl.Location = new System.Drawing.Point(190, 0);
            this._sellRequestsControl.Name = "_sellRequestsControl";
            this._sellRequestsControl.Size = new System.Drawing.Size(894, 661);
            this._sellRequestsControl.TabIndex = 6;
            // 
            // paymentsControl
            // 
            this.paymentsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentsControl.Location = new System.Drawing.Point(190, 0);
            this.paymentsControl.Name = "paymentsControl";
            this.paymentsControl.Size = new System.Drawing.Size(894, 661);
            this.paymentsControl.TabIndex = 5;
            // 
            // productControl
            // 
            this.productControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productControl.Location = new System.Drawing.Point(190, 0);
            this.productControl.Name = "productControl";
            this.productControl.Size = new System.Drawing.Size(894, 661);
            this.productControl.TabIndex = 2;
            // 
            // memberControl
            // 
            this.memberControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberControl.Location = new System.Drawing.Point(190, 0);
            this.memberControl.Name = "memberControl";
            this.memberControl.Size = new System.Drawing.Size(894, 661);
            this.memberControl.TabIndex = 7;
            // 
            // logViewerControl
            // 
            this.logViewerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logViewerControl.Location = new System.Drawing.Point(190, 0);
            this.logViewerControl.Name = "logViewerControl";
            this.logViewerControl.Size = new System.Drawing.Size(894, 661);
            this.logViewerControl.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.logViewerControl);
            this.Controls.Add(this.memberControl);
            this.Controls.Add(this._sellRequestsControl);
            this.Controls.Add(this.paymentsControl);
            this.Controls.Add(this.productControl);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private SellRequestsControl _sellRequestsControl;
        private MemberControl memberControl;
        private LogViewerControl logViewerControl;
    }
}

