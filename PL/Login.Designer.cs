﻿namespace PL
{
    partial class Login
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
            this.textBoxUserName = new CustomControls.RJControls.RJTextBox();
            this.textBoxPassWord = new CustomControls.RJControls.RJTextBox();
            this.buttonLogin = new CustomControls.RJControls.RJButton();
            this.buttonRegister = new CustomControls.RJControls.RJButton();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUserName.BorderColor = System.Drawing.Color.Black;
            this.textBoxUserName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxUserName.BorderRadius = 15;
            this.textBoxUserName.BorderSize = 2;
            this.textBoxUserName.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxUserName.Location = new System.Drawing.Point(79, 153);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserName.Multiline = false;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxUserName.PasswordChar = false;
            this.textBoxUserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxUserName.PlaceholderText = "";
            this.textBoxUserName.Size = new System.Drawing.Size(250, 38);
            this.textBoxUserName.TabIndex = 0;
            this.textBoxUserName.Texts = "Admin";
            this.textBoxUserName.UnderlinedStyle = false;
            // 
            // textBoxPassWord
            // 
            this.textBoxPassWord.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassWord.BorderColor = System.Drawing.Color.Black;
            this.textBoxPassWord.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxPassWord.BorderRadius = 15;
            this.textBoxPassWord.BorderSize = 2;
            this.textBoxPassWord.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPassWord.Location = new System.Drawing.Point(79, 199);
            this.textBoxPassWord.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassWord.Multiline = false;
            this.textBoxPassWord.Name = "textBoxPassWord";
            this.textBoxPassWord.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxPassWord.PasswordChar = true;
            this.textBoxPassWord.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPassWord.PlaceholderText = "";
            this.textBoxPassWord.Size = new System.Drawing.Size(250, 38);
            this.textBoxPassWord.TabIndex = 1;
            this.textBoxPassWord.Texts = "Password";
            this.textBoxPassWord.UnderlinedStyle = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonLogin.BorderRadius = 15;
            this.buttonLogin.BorderSize = 0;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(79, 244);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(120, 33);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.TextColor = System.Drawing.Color.White;
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.White;
            this.buttonRegister.BackgroundColor = System.Drawing.Color.White;
            this.buttonRegister.BorderColor = System.Drawing.Color.Orange;
            this.buttonRegister.BorderRadius = 15;
            this.buttonRegister.BorderSize = 2;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonRegister.Location = new System.Drawing.Point(209, 244);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(120, 33);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonRegister.UseVisualStyleBackColor = false;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.labelWelcome);
            this.panelLeft.Location = new System.Drawing.Point(-2, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(396, 448);
            this.panelLeft.TabIndex = 4;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Font = new System.Drawing.Font("Poppins", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(55, 51);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(338, 151);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.textBoxUserName);
            this.panelRight.Controls.Add(this.textBoxPassWord);
            this.panelRight.Controls.Add(this.buttonRegister);
            this.panelRight.Controls.Add(this.buttonLogin);
            this.panelRight.Location = new System.Drawing.Point(393, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(416, 451);
            this.panelRight.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PL.Properties.Resources.login;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(29, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 293);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 15;
            this.Text = "Login";
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJTextBox textBoxUserName;
        private CustomControls.RJControls.RJTextBox textBoxPassWord;
        private CustomControls.RJControls.RJButton buttonRegister;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private CustomControls.RJControls.RJButton buttonLogin;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}