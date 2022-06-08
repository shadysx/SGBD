namespace PL
{
    partial class HistoryPurchase
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
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelIdOrdered = new System.Windows.Forms.Label();
            this.labelTotalQuantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(223, 16);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(98, 30);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "labelDate";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(780, 16);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(145, 30);
            this.labelTotalPrice.TabIndex = 10;
            this.labelTotalPrice.Text = "labelTotalPrice";
            // 
            // labelIdOrdered
            // 
            this.labelIdOrdered.AutoSize = true;
            this.labelIdOrdered.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdOrdered.Location = new System.Drawing.Point(17, 16);
            this.labelIdOrdered.Name = "labelIdOrdered";
            this.labelIdOrdered.Size = new System.Drawing.Size(145, 30);
            this.labelIdOrdered.TabIndex = 11;
            this.labelIdOrdered.Text = "labelIdOrdered";
            // 
            // labelTotalQuantity
            // 
            this.labelTotalQuantity.AutoSize = true;
            this.labelTotalQuantity.Font = new System.Drawing.Font("Poppins", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalQuantity.Location = new System.Drawing.Point(563, 16);
            this.labelTotalQuantity.Name = "labelTotalQuantity";
            this.labelTotalQuantity.Size = new System.Drawing.Size(179, 30);
            this.labelTotalQuantity.TabIndex = 12;
            this.labelTotalQuantity.Text = "labelTotalQuantity";
            // 
            // HistoryPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1109, 60);
            this.Controls.Add(this.labelTotalQuantity);
            this.Controls.Add(this.labelIdOrdered);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryPurchase";
            this.Text = "HistoryPurchase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelIdOrdered;
        private System.Windows.Forms.Label labelTotalQuantity;
    }
}