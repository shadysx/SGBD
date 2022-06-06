namespace PL
{
    partial class Basket
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelTotalNumberArticle = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1183, 588);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTotalPrice);
            this.panel1.Controls.Add(this.labelTotalNumberArticle);
            this.panel1.Controls.Add(this.labelNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Location = new System.Drawing.Point(3, 595);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 89);
            this.panel1.TabIndex = 7;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(989, 24);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(85, 56);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(628, 50);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(131, 34);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Total Price : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(921, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buy :";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.Location = new System.Drawing.Point(628, 16);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(210, 34);
            this.labelNumber.TabIndex = 3;
            this.labelNumber.Text = "Number of articles : ";
            // 
            // labelTotalNumberArticle
            // 
            this.labelTotalNumberArticle.AutoSize = true;
            this.labelTotalNumberArticle.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalNumberArticle.Location = new System.Drawing.Point(831, 16);
            this.labelTotalNumberArticle.Name = "labelTotalNumberArticle";
            this.labelTotalNumberArticle.Size = new System.Drawing.Size(65, 34);
            this.labelTotalNumberArticle.TabIndex = 4;
            this.labelTotalNumberArticle.Text = "label";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(752, 50);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(65, 34);
            this.labelTotalPrice.TabIndex = 5;
            this.labelTotalPrice.Text = "label";
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 686);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Basket";
            this.Text = "Basket";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPrice;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelTotalNumberArticle;
    }
}