
namespace TekManager.Forms
{
    partial class ViewSellRequest
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.qualityLabel = new System.Windows.Forms.Label();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.memberIdLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.reasonTextBox = new System.Windows.Forms.RichTextBox();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.imagesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(420, 697);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(220, 82);
            this.DeleteButton.TabIndex = 38;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(39, 697);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(220, 82);
            this.SaveButton.TabIndex = 34;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(21, 453);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(85, 29);
            this.statusLabel.TabIndex = 26;
            this.statusLabel.Text = "Status:";
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualityLabel.Location = new System.Drawing.Point(13, 169);
            this.qualityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(99, 29);
            this.qualityLabel.TabIndex = 24;
            this.qualityLabel.Text = "Quality: ";
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdLabel.Location = new System.Drawing.Point(13, 93);
            this.productIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(134, 29);
            this.productIdLabel.TabIndex = 23;
            this.productIdLabel.Text = "Product Id: ";
            // 
            // memberIdLabel
            // 
            this.memberIdLabel.AutoSize = true;
            this.memberIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIdLabel.Location = new System.Drawing.Point(13, 51);
            this.memberIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberIdLabel.Name = "memberIdLabel";
            this.memberIdLabel.Size = new System.Drawing.Size(141, 29);
            this.memberIdLabel.TabIndex = 21;
            this.memberIdLabel.Text = "Member Id: ";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(13, 9);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(45, 29);
            this.IdLabel.TabIndex = 20;
            this.IdLabel.Text = "Id: ";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Pending",
            "Denied",
            "Accepted",
            "Finished"});
            this.statusComboBox.Location = new System.Drawing.Point(123, 450);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(457, 37);
            this.statusComboBox.TabIndex = 39;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(13, 210);
            this.dateTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(137, 29);
            this.dateTimeLabel.TabIndex = 28;
            this.dateTimeLabel.Text = "Date Time: ";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(13, 257);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(141, 29);
            this.descriptionLabel.TabIndex = 30;
            this.descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(18, 306);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(636, 124);
            this.descriptionTextBox.TabIndex = 40;
            this.descriptionTextBox.Text = "";
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.Location = new System.Drawing.Point(26, 541);
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(628, 137);
            this.reasonTextBox.TabIndex = 41;
            this.reasonTextBox.Text = "";
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonLabel.Location = new System.Drawing.Point(21, 509);
            this.reasonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(102, 29);
            this.reasonLabel.TabIndex = 42;
            this.reasonLabel.Text = "Reason:";
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(13, 131);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(179, 29);
            this.productNameLabel.TabIndex = 43;
            this.productNameLabel.Text = "Product Name: ";
            // 
            // imagesButton
            // 
            this.imagesButton.Location = new System.Drawing.Point(549, 15);
            this.imagesButton.Name = "imagesButton";
            this.imagesButton.Size = new System.Drawing.Size(120, 50);
            this.imagesButton.TabIndex = 44;
            this.imagesButton.Text = "Images";
            this.imagesButton.UseVisualStyleBackColor = true;
            this.imagesButton.Click += new System.EventHandler(this.imagesButton_Click);
            // 
            // ViewSellRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 818);
            this.Controls.Add(this.imagesButton);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.reasonLabel);
            this.Controls.Add(this.reasonTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.qualityLabel);
            this.Controls.Add(this.productIdLabel);
            this.Controls.Add(this.memberIdLabel);
            this.Controls.Add(this.IdLabel);
            this.Name = "ViewSellRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell Request";
            this.Load += new System.EventHandler(this.ViewSellRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label qualityLabel;
        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.Label memberIdLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.RichTextBox reasonTextBox;
        private System.Windows.Forms.Label reasonLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Button imagesButton;
    }
}