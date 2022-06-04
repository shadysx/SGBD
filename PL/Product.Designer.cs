namespace PL
{
    partial class Product
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
            this.labelVendeur = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.labelPays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelVendeur
            // 
            this.labelVendeur.AutoSize = true;
            this.labelVendeur.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendeur.Location = new System.Drawing.Point(12, 9);
            this.labelVendeur.Name = "labelVendeur";
            this.labelVendeur.Size = new System.Drawing.Size(120, 28);
            this.labelVendeur.TabIndex = 0;
            this.labelVendeur.Text = "labelVendeur";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrix.Location = new System.Drawing.Point(917, 24);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(79, 28);
            this.labelPrix.TabIndex = 1;
            this.labelPrix.Text = "labelPrix";
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantite.Location = new System.Drawing.Point(482, 24);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(122, 28);
            this.labelQuantite.TabIndex = 2;
            this.labelQuantite.Text = "labelQuantite";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButton1.IconColor = System.Drawing.Color.IndianRed;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1012, 17);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(60, 40);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // labelPays
            // 
            this.labelPays.AutoSize = true;
            this.labelPays.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPays.Location = new System.Drawing.Point(12, 37);
            this.labelPays.Name = "labelPays";
            this.labelPays.Size = new System.Drawing.Size(89, 28);
            this.labelPays.TabIndex = 4;
            this.labelPays.Text = "labelPays";
            // 
            // ShopArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 72);
            this.Controls.Add(this.labelPays);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.labelQuantite);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.labelVendeur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopArticle";
            this.Text = "ShopArticle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVendeur;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelQuantite;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label labelPays;
    }
}