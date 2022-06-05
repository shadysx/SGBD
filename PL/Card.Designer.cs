namespace PL
{
    partial class Card
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelCard = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1248, 591);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.Controls.Add(this.labelCard);
            this.panelTop.Location = new System.Drawing.Point(2, 1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1250, 47);
            this.panelTop.TabIndex = 7;
            // 
            // labelCard
            // 
            this.labelCard.AutoSize = true;
            this.labelCard.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCard.Location = new System.Drawing.Point(10, 2);
            this.labelCard.Name = "labelCard";
            this.labelCard.Size = new System.Drawing.Size(89, 48);
            this.labelCard.TabIndex = 0;
            this.labelCard.Text = "Card";
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 653);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Card";
            this.Text = "Card";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelCard;
    }
}