﻿namespace PL
{
    partial class Article
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
            this.components = new System.ComponentModel.Container();
            this.labelVendeur = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.labelPays = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelPriceSelected = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVendeur
            // 
            this.labelVendeur.AutoSize = true;
            this.labelVendeur.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendeur.Location = new System.Drawing.Point(12, 11);
            this.labelVendeur.Name = "labelVendeur";
            this.labelVendeur.Size = new System.Drawing.Size(126, 28);
            this.labelVendeur.TabIndex = 0;
            this.labelVendeur.Text = "labelVendeur";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrix.Location = new System.Drawing.Point(596, 14);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(70, 23);
            this.labelPrix.TabIndex = 1;
            this.labelPrix.Text = "labelPrix";
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantite.Location = new System.Drawing.Point(596, 39);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(103, 23);
            this.labelQuantite.TabIndex = 2;
            this.labelQuantite.Text = "labelQuantite";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.IndianRed;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(1036, 16);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.iconButton1.Size = new System.Drawing.Size(46, 37);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // labelPays
            // 
            this.labelPays.AutoSize = true;
            this.labelPays.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPays.Location = new System.Drawing.Point(15, 39);
            this.labelPays.Name = "labelPays";
            this.labelPays.Size = new System.Drawing.Size(73, 23);
            this.labelPays.TabIndex = 4;
            this.labelPays.Text = "labelPays";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(954, 25);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelPriceSelected
            // 
            this.labelPriceSelected.AutoSize = true;
            this.labelPriceSelected.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceSelected.Location = new System.Drawing.Point(803, 25);
            this.labelPriceSelected.Name = "labelPriceSelected";
            this.labelPriceSelected.Size = new System.Drawing.Size(44, 23);
            this.labelPriceSelected.TabIndex = 6;
            this.labelPriceSelected.Text = "Price";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(253, 14);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(96, 23);
            this.labelAddress.TabIndex = 7;
            this.labelAddress.Text = "labelAddress";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(253, 39);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(67, 23);
            this.labelCity.TabIndex = 8;
            this.labelCity.Text = "labelCity";
            // 
            // Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 72);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelPriceSelected);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelPays);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.labelQuantite);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.labelVendeur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Article";
            this.Text = "ShopArticle";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVendeur;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelQuantite;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label labelPays;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelPriceSelected;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCity;
    }
}