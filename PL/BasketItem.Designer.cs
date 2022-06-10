namespace PL
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
            this.labelQuantityChanged = new System.Windows.Forms.Label();
            this.iconButtonDelete = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(886, 68);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(86, 26);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "labelPrice";
            // 
            // labelNameArticle
            // 
            this.labelNameArticle.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameArticle.Location = new System.Drawing.Point(162, 38);
            this.labelNameArticle.Name = "labelNameArticle";
            this.labelNameArticle.Size = new System.Drawing.Size(290, 56);
            this.labelNameArticle.TabIndex = 7;
            this.labelNameArticle.Text = "labelNameArticle";
            // 
            // labelTypeArticle
            // 
            this.labelTypeArticle.AutoSize = true;
            this.labelTypeArticle.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeArticle.Location = new System.Drawing.Point(160, 5);
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
            this.labelShopName.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShopName.Location = new System.Drawing.Point(472, 12);
            this.labelShopName.Name = "labelShopName";
            this.labelShopName.Size = new System.Drawing.Size(133, 26);
            this.labelShopName.TabIndex = 12;
            this.labelShopName.Text = "labelShopName";
            // 
            // labelShopAddress
            // 
            this.labelShopAddress.AutoSize = true;
            this.labelShopAddress.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShopAddress.Location = new System.Drawing.Point(472, 46);
            this.labelShopAddress.Name = "labelShopAddress";
            this.labelShopAddress.Size = new System.Drawing.Size(149, 26);
            this.labelShopAddress.TabIndex = 13;
            this.labelShopAddress.Text = "labelShopAddress";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.Location = new System.Drawing.Point(162, 87);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(110, 26);
            this.labelCountry.TabIndex = 14;
            this.labelCountry.Text = "labelCountry";
            // 
            // labelShopCity
            // 
            this.labelShopCity.AutoSize = true;
            this.labelShopCity.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShopCity.Location = new System.Drawing.Point(472, 80);
            this.labelShopCity.Name = "labelShopCity";
            this.labelShopCity.Size = new System.Drawing.Size(117, 26);
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
            this.iconButtonInfo.Location = new System.Drawing.Point(1033, 7);
            this.iconButtonInfo.Name = "iconButtonInfo";
            this.iconButtonInfo.Size = new System.Drawing.Size(53, 49);
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
            this.iconButtonMinus.Location = new System.Drawing.Point(890, 37);
            this.iconButtonMinus.Name = "iconButtonMinus";
            this.iconButtonMinus.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.iconButtonMinus.Size = new System.Drawing.Size(26, 25);
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
            this.iconButtonPlus.Location = new System.Drawing.Point(947, 37);
            this.iconButtonPlus.Name = "iconButtonPlus";
            this.iconButtonPlus.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.iconButtonPlus.Size = new System.Drawing.Size(26, 25);
            this.iconButtonPlus.TabIndex = 17;
            this.iconButtonPlus.UseVisualStyleBackColor = false;
            this.iconButtonPlus.Click += new System.EventHandler(this.iconButtonPlus_Click);
            // 
            // labelQuantityInstant
            // 
            this.labelQuantityInstant.AutoSize = true;
            this.labelQuantityInstant.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantityInstant.Location = new System.Drawing.Point(917, 36);
            this.labelQuantityInstant.Name = "labelQuantityInstant";
            this.labelQuantityInstant.Size = new System.Drawing.Size(28, 26);
            this.labelQuantityInstant.TabIndex = 18;
            this.labelQuantityInstant.Text = "15";
            // 
            // labelQuantityChanged
            // 
            this.labelQuantityChanged.AutoSize = true;
            this.labelQuantityChanged.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantityChanged.ForeColor = System.Drawing.Color.IndianRed;
            this.labelQuantityChanged.Location = new System.Drawing.Point(835, 15);
            this.labelQuantityChanged.Name = "labelQuantityChanged";
            this.labelQuantityChanged.Size = new System.Drawing.Size(114, 19);
            this.labelQuantityChanged.TabIndex = 19;
            this.labelQuantityChanged.Text = "Quantity changed !";
            this.labelQuantityChanged.Visible = false;
            // 
            // iconButtonDelete
            // 
            this.iconButtonDelete.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonDelete.FlatAppearance.BorderSize = 0;
            this.iconButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconButtonDelete.IconColor = System.Drawing.Color.Black;
            this.iconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonDelete.Location = new System.Drawing.Point(1033, 59);
            this.iconButtonDelete.Name = "iconButtonDelete";
            this.iconButtonDelete.Size = new System.Drawing.Size(53, 49);
            this.iconButtonDelete.TabIndex = 20;
            this.iconButtonDelete.UseVisualStyleBackColor = false;
            this.iconButtonDelete.Click += new System.EventHandler(this.iconButtonDelete_Click);
            // 
            // BasketItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 114);
            this.Controls.Add(this.iconButtonDelete);
            this.Controls.Add(this.labelQuantityChanged);
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
        private FontAwesome.Sharp.IconButton iconButtonInfo;
        private System.Windows.Forms.Label labelNameArticle;
        private System.Windows.Forms.Label labelTypeArticle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelShopName;
        private System.Windows.Forms.Label labelShopAddress;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelShopCity;
        public System.Windows.Forms.Label labelPrice;
        public System.Windows.Forms.Label labelQuantity;
        public FontAwesome.Sharp.IconButton iconButtonMinus;
        public FontAwesome.Sharp.IconButton iconButtonPlus;
        public System.Windows.Forms.Label labelQuantityInstant;
        public System.Windows.Forms.Label labelQuantityChanged;
        private FontAwesome.Sharp.IconButton iconButtonDelete;
    }
}