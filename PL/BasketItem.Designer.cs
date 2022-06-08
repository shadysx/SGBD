﻿namespace PL
{
    partial class BasketItem
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
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelNameArticle = new System.Windows.Forms.Label();
            this.labelTypeArticle = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelShopName = new System.Windows.Forms.Label();
            this.labelShopAddress = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelShopCity = new System.Windows.Forms.Label();
            this.iconButtonInfo = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButtonMinus = new FontAwesome.Sharp.IconButton();
            this.iconButtonPlus = new FontAwesome.Sharp.IconButton();
            this.labelQuantityInstant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(801, 67);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(86, 26);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "labelPrice";
            // 
            // labelNameArticle
            // 
            this.labelNameArticle.AutoSize = true;
            this.labelNameArticle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameArticle.Location = new System.Drawing.Point(162, 50);
            this.labelNameArticle.Name = "labelNameArticle";
            this.labelNameArticle.Size = new System.Drawing.Size(144, 26);
            this.labelNameArticle.TabIndex = 7;
            this.labelNameArticle.Text = "labelNameArticle";
            // 
            // labelTypeArticle
            // 
            this.labelTypeArticle.AutoSize = true;
            this.labelTypeArticle.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeArticle.Location = new System.Drawing.Point(160, 8);
            this.labelTypeArticle.Name = "labelTypeArticle";
            this.labelTypeArticle.Size = new System.Drawing.Size(186, 36);
            this.labelTypeArticle.TabIndex = 6;
            this.labelTypeArticle.Text = "labelTypeArticle";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(801, 35);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(89, 26);
            this.labelQuantity.TabIndex = 10;
            this.labelQuantity.Text = "Quantity : ";
            // 
            // labelShopName
            // 
            this.labelShopName.AutoSize = true;
            this.labelShopName.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShopName.Location = new System.Drawing.Point(422, 18);
            this.labelShopName.Name = "labelShopName";
            this.labelShopName.Size = new System.Drawing.Size(134, 26);
            this.labelShopName.TabIndex = 12;
            this.labelShopName.Text = "labelShopName";
            // 
            // labelShopAddress
            // 
            this.labelShopAddress.AutoSize = true;
            this.labelShopAddress.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShopAddress.Location = new System.Drawing.Point(422, 50);
            this.labelShopAddress.Name = "labelShopAddress";
            this.labelShopAddress.Size = new System.Drawing.Size(150, 26);
            this.labelShopAddress.TabIndex = 13;
            this.labelShopAddress.Text = "labelShopAddress";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.Location = new System.Drawing.Point(162, 82);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(111, 26);
            this.labelCountry.TabIndex = 14;
            this.labelCountry.Text = "labelCountry";
            // 
            // labelShopCity
            // 
            this.labelShopCity.AutoSize = true;
            this.labelShopCity.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShopCity.Location = new System.Drawing.Point(422, 82);
            this.labelShopCity.Name = "labelShopCity";
            this.labelShopCity.Size = new System.Drawing.Size(118, 26);
            this.labelShopCity.TabIndex = 15;
            this.labelShopCity.Text = "labelShopCity";
            // 
            // iconButtonInfo
            // 
            this.iconButtonInfo.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonInfo.FlatAppearance.BorderSize = 0;
            this.iconButtonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonInfo.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconButtonInfo.IconColor = System.Drawing.Color.Black;
            this.iconButtonInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonInfo.Location = new System.Drawing.Point(1033, 32);
            this.iconButtonInfo.Name = "iconButtonInfo";
            this.iconButtonInfo.Size = new System.Drawing.Size(53, 51);
            this.iconButtonInfo.TabIndex = 8;
            this.iconButtonInfo.UseVisualStyleBackColor = false;
            this.iconButtonInfo.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // iconButtonMinus
            // 
            this.iconButtonMinus.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonMinus.FlatAppearance.BorderSize = 0;
            this.iconButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButtonMinus.IconColor = System.Drawing.Color.Black;
            this.iconButtonMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMinus.IconSize = 20;
            this.iconButtonMinus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonMinus.Location = new System.Drawing.Point(885, 35);
            this.iconButtonMinus.Name = "iconButtonMinus";
            this.iconButtonMinus.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.iconButtonMinus.Size = new System.Drawing.Size(30, 30);
            this.iconButtonMinus.TabIndex = 16;
            this.iconButtonMinus.UseVisualStyleBackColor = false;
            this.iconButtonMinus.Click += new System.EventHandler(this.iconButtonMinus_Click);
            // 
            // iconButtonPlus
            // 
            this.iconButtonPlus.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonPlus.FlatAppearance.BorderSize = 0;
            this.iconButtonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPlus.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonPlus.IconColor = System.Drawing.Color.Black;
            this.iconButtonPlus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPlus.IconSize = 20;
            this.iconButtonPlus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonPlus.Location = new System.Drawing.Point(942, 35);
            this.iconButtonPlus.Name = "iconButtonPlus";
            this.iconButtonPlus.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.iconButtonPlus.Size = new System.Drawing.Size(30, 30);
            this.iconButtonPlus.TabIndex = 17;
            this.iconButtonPlus.UseVisualStyleBackColor = false;
            this.iconButtonPlus.Click += new System.EventHandler(this.iconButtonPlus_Click);
            // 
            // labelQuantityInstant
            // 
            this.labelQuantityInstant.AutoSize = true;
            this.labelQuantityInstant.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantityInstant.Location = new System.Drawing.Point(918, 36);
            this.labelQuantityInstant.Name = "labelQuantityInstant";
            this.labelQuantityInstant.Size = new System.Drawing.Size(28, 26);
            this.labelQuantityInstant.TabIndex = 18;
            this.labelQuantityInstant.Text = "15";
            // 
            // BasketItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 114);
            this.Controls.Add(this.labelQuantityInstant);
            this.Controls.Add(this.iconButtonPlus);
            this.Controls.Add(this.iconButtonMinus);
            this.Controls.Add(this.labelShopCity);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelShopAddress);
            this.Controls.Add(this.labelShopName);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.iconButtonInfo);
            this.Controls.Add(this.labelNameArticle);
            this.Controls.Add(this.labelTypeArticle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BasketItem";
            this.Text = "CardItem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrice;
        private FontAwesome.Sharp.IconButton iconButtonInfo;
        private System.Windows.Forms.Label labelNameArticle;
        private System.Windows.Forms.Label labelTypeArticle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelShopName;
        private System.Windows.Forms.Label labelShopAddress;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelShopCity;
        private FontAwesome.Sharp.IconButton iconButtonMinus;
        private FontAwesome.Sharp.IconButton iconButtonPlus;
        private System.Windows.Forms.Label labelQuantityInstant;
    }
}