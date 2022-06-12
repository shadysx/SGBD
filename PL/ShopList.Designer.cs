namespace PL
{
    partial class ShopList
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelShopPostalCode = new System.Windows.Forms.Label();
            this.labelShopCountry = new System.Windows.Forms.Label();
            this.labelShopCity = new System.Windows.Forms.Label();
            this.labelShopAddress = new System.Windows.Forms.Label();
            this.labelShopName = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(12, 7);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 19);
            this.labelID.TabIndex = 15;
            this.labelID.Text = "ID";
            // 
            // labelShopPostalCode
            // 
            this.labelShopPostalCode.AutoSize = true;
            this.labelShopPostalCode.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShopPostalCode.Location = new System.Drawing.Point(711, 7);
            this.labelShopPostalCode.Name = "labelShopPostalCode";
            this.labelShopPostalCode.Size = new System.Drawing.Size(125, 19);
            this.labelShopPostalCode.TabIndex = 12;
            this.labelShopPostalCode.Text = "labelShopPostalCode";
            // 
            // labelShopCountry
            // 
            this.labelShopCountry.AutoSize = true;
            this.labelShopCountry.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShopCountry.Location = new System.Drawing.Point(572, 7);
            this.labelShopCountry.Name = "labelShopCountry";
            this.labelShopCountry.Size = new System.Drawing.Size(106, 19);
            this.labelShopCountry.TabIndex = 11;
            this.labelShopCountry.Text = "labelShopCountry";
            // 
            // labelShopCity
            // 
            this.labelShopCity.AutoSize = true;
            this.labelShopCity.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShopCity.Location = new System.Drawing.Point(414, 7);
            this.labelShopCity.Name = "labelShopCity";
            this.labelShopCity.Size = new System.Drawing.Size(84, 19);
            this.labelShopCity.TabIndex = 10;
            this.labelShopCity.Text = "labelShopCity";
            // 
            // labelShopAddress
            // 
            this.labelShopAddress.AutoSize = true;
            this.labelShopAddress.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShopAddress.Location = new System.Drawing.Point(215, 7);
            this.labelShopAddress.Name = "labelShopAddress";
            this.labelShopAddress.Size = new System.Drawing.Size(107, 19);
            this.labelShopAddress.TabIndex = 9;
            this.labelShopAddress.Text = "labelShopAddress";
            // 
            // labelShopName
            // 
            this.labelShopName.AutoSize = true;
            this.labelShopName.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShopName.Location = new System.Drawing.Point(82, 7);
            this.labelShopName.Name = "labelShopName";
            this.labelShopName.Size = new System.Drawing.Size(96, 19);
            this.labelShopName.TabIndex = 8;
            this.labelShopName.Text = "labelShopName";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(817, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(28, 27);
            this.iconButton2.TabIndex = 14;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(775, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(31, 27);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // ShopList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 31);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.labelShopPostalCode);
            this.Controls.Add(this.labelShopCountry);
            this.Controls.Add(this.labelShopCity);
            this.Controls.Add(this.labelShopAddress);
            this.Controls.Add(this.labelShopName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopList";
            this.Text = "ShopList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label labelShopPostalCode;
        private System.Windows.Forms.Label labelShopCountry;
        private System.Windows.Forms.Label labelShopCity;
        private System.Windows.Forms.Label labelShopAddress;
        private System.Windows.Forms.Label labelShopName;
    }
}