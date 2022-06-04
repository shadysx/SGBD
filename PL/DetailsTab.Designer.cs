namespace PL
{
    partial class DetailsTab
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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelTop = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.labelProductDesctiption = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.ForeColor = System.Drawing.Color.White;
            this.labelNom.Location = new System.Drawing.Point(366, 4);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(155, 48);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "labelNom";
            this.labelNom.Click += new System.EventHandler(this.labelNom_Click);
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.ForeColor = System.Drawing.Color.White;
            this.labelTop.Location = new System.Drawing.Point(71, 4);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(305, 48);
            this.labelTop.TabIndex = 3;
            this.labelTop.Text = "Produit Selectionné :";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.Controls.Add(this.iconButton1);
            this.panelTop.Controls.Add(this.labelTop);
            this.panelTop.Controls.Add(this.labelNom);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1254, 47);
            this.panelTop.TabIndex = 4;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(12, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(53, 44);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1254, 589);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Controls.Add(this.labelAvailable);
            this.panel2.Controls.Add(this.panelRight);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1230, 469);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(1, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(464, 386);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailable.ForeColor = System.Drawing.Color.Black;
            this.labelAvailable.Location = new System.Drawing.Point(3, 430);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(211, 34);
            this.labelAvailable.TabIndex = 4;
            this.labelAvailable.Text = "Available Products :";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.labelDescription);
            this.panelRight.Controls.Add(this.labelProductDesctiption);
            this.panelRight.Location = new System.Drawing.Point(486, 14);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(741, 384);
            this.panelRight.TabIndex = 1;
            // 
            // labelProductDesctiption
            // 
            this.labelProductDesctiption.AutoSize = true;
            this.labelProductDesctiption.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductDesctiption.ForeColor = System.Drawing.Color.Black;
            this.labelProductDesctiption.Location = new System.Drawing.Point(7, 12);
            this.labelProductDesctiption.Name = "labelProductDesctiption";
            this.labelProductDesctiption.Size = new System.Drawing.Size(184, 28);
            this.labelProductDesctiption.TabIndex = 5;
            this.labelProductDesctiption.Text = "Product Description :";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(17, 45);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(105, 22);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "labelDescription";
            // 
            // DetailsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 653);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelTop);
            this.Name = "DetailsTab";
            this.Text = "ArticleDetails";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelAvailable;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelProductDesctiption;
        private System.Windows.Forms.Label labelDescription;
    }
}