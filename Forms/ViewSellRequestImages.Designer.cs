
namespace TekManager.Forms
{
    partial class ViewSellRequestImages
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
            this.sellRequestImageBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.currentImageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sellRequestImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sellRequestImageBox
            // 
            this.sellRequestImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellRequestImageBox.Location = new System.Drawing.Point(12, 12);
            this.sellRequestImageBox.Name = "sellRequestImageBox";
            this.sellRequestImageBox.Size = new System.Drawing.Size(944, 613);
            this.sellRequestImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sellRequestImageBox.TabIndex = 0;
            this.sellRequestImageBox.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.backButton.Location = new System.Drawing.Point(230, 646);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(140, 67);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Backwards";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.forwardButton.Location = new System.Drawing.Point(573, 646);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(140, 67);
            this.forwardButton.TabIndex = 2;
            this.forwardButton.Text = "Forwards";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // currentImageLabel
            // 
            this.currentImageLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.currentImageLabel.AutoSize = true;
            this.currentImageLabel.Location = new System.Drawing.Point(422, 669);
            this.currentImageLabel.Name = "currentImageLabel";
            this.currentImageLabel.Size = new System.Drawing.Size(98, 20);
            this.currentImageLabel.TabIndex = 3;
            this.currentImageLabel.Text = "Image 0 of 0";
            // 
            // ViewSellRequestImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 729);
            this.Controls.Add(this.currentImageLabel);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.sellRequestImageBox);
            this.Name = "ViewSellRequestImages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell Request Images";
            this.Load += new System.EventHandler(this.ViewSellRequestImages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellRequestImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sellRequestImageBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Label currentImageLabel;
    }
}