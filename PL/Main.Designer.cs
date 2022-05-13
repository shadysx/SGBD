namespace PL
{
    partial class Main
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.iconButtonHomr = new FontAwesome.Sharp.IconButton();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.pnLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.Black;
            this.pnTop.Controls.Add(this.iconPictureBox1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1328, 75);
            this.pnTop.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackgroundImage = global::PL.Properties.Resources.Stock_Overflow1;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 52;
            this.iconPictureBox1.Location = new System.Drawing.Point(18, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(182, 52);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnLeft.Controls.Add(this.iconButtonHomr);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 75);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(200, 697);
            this.pnLeft.TabIndex = 1;
            // 
            // iconButtonHomr
            // 
            this.iconButtonHomr.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonHomr.FlatAppearance.BorderSize = 0;
            this.iconButtonHomr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHomr.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonHomr.ForeColor = System.Drawing.Color.White;
            this.iconButtonHomr.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButtonHomr.IconColor = System.Drawing.Color.White;
            this.iconButtonHomr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHomr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHomr.Location = new System.Drawing.Point(33, 108);
            this.iconButtonHomr.Name = "iconButtonHomr";
            this.iconButtonHomr.Size = new System.Drawing.Size(136, 47);
            this.iconButtonHomr.TabIndex = 0;
            this.iconButtonHomr.Text = "Home";
            this.iconButtonHomr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonHomr.UseVisualStyleBackColor = false;
            this.iconButtonHomr.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 772);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.pnLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnLeft;
        private FontAwesome.Sharp.IconButton iconButtonHomr;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}