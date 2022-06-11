namespace PL
{
    partial class AdminPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPasswordConfirmation = new System.Windows.Forms.Label();
            this.textBoxUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxConfirmPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxLastName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.datePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCountry = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxShop = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCreateEmployee = new CustomControls.RJControls.RJButton();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProviderUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderBirthDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCountry = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBirthDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Créer un nouvel employé";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(42, 93);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(395, 28);
            this.textBoxEmail.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.textBoxEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxEmail.StateCommon.Border.Rounding = 12;
            this.textBoxEmail.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.TabIndex = 65;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(37, 65);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(65, 25);
            this.labelEmail.TabIndex = 66;
            this.labelEmail.Text = "Email";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(37, 134);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(162, 25);
            this.labelUserName.TabIndex = 67;
            this.labelUserName.Text = "Nom de compte";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(37, 213);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(142, 25);
            this.labelPassword.TabIndex = 68;
            this.labelPassword.Text = "Mot de passe";
            // 
            // labelPasswordConfirmation
            // 
            this.labelPasswordConfirmation.AutoSize = true;
            this.labelPasswordConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordConfirmation.ForeColor = System.Drawing.Color.White;
            this.labelPasswordConfirmation.Location = new System.Drawing.Point(244, 213);
            this.labelPasswordConfirmation.Name = "labelPasswordConfirmation";
            this.labelPasswordConfirmation.Size = new System.Drawing.Size(133, 25);
            this.labelPasswordConfirmation.TabIndex = 69;
            this.labelPasswordConfirmation.Text = "Confirmation";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(42, 162);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(395, 28);
            this.textBoxUsername.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxUsername.StateCommon.Border.Rounding = 12;
            this.textBoxUsername.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.TabIndex = 70;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(42, 241);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(188, 28);
            this.textBoxPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxPassword.StateCommon.Border.Rounding = 12;
            this.textBoxPassword.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.TabIndex = 71;
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(249, 241);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(188, 28);
            this.textBoxConfirmPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxConfirmPassword.StateCommon.Border.Rounding = 12;
            this.textBoxConfirmPassword.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPassword.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(244, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 73;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 74;
            this.label3.Text = "Nom";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(249, 320);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(188, 28);
            this.textBoxFirstName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxFirstName.StateCommon.Border.Rounding = 12;
            this.textBoxFirstName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.TabIndex = 75;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(42, 320);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(188, 28);
            this.textBoxLastName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxLastName.StateCommon.Border.Rounding = 12;
            this.textBoxLastName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.TabIndex = 76;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(42, 394);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(188, 29);
            this.datePicker.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.datePicker.StateCommon.Border.Rounding = 12;
            this.datePicker.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 78;
            this.label4.Text = "Date de naissance";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(249, 394);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(188, 28);
            this.textBoxCountry.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxCountry.StateCommon.Border.Rounding = 12;
            this.textBoxCountry.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCountry.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(246, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 80;
            this.label5.Text = "Pays";
            // 
            // comboBoxShop
            // 
            this.comboBoxShop.DropDownWidth = 180;
            this.comboBoxShop.Location = new System.Drawing.Point(42, 471);
            this.comboBoxShop.Name = "comboBoxShop";
            this.comboBoxShop.Size = new System.Drawing.Size(188, 29);
            this.comboBoxShop.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboBoxShop.StateCommon.ComboBox.Border.Rounding = 12;
            this.comboBoxShop.TabIndex = 81;
            this.comboBoxShop.Text = "kryptonComboBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 25);
            this.label6.TabIndex = 82;
            this.label6.Text = "Magasin de l\'employé";
            // 
            // buttonCreateEmployee
            // 
            this.buttonCreateEmployee.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCreateEmployee.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCreateEmployee.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCreateEmployee.BorderRadius = 12;
            this.buttonCreateEmployee.BorderSize = 0;
            this.buttonCreateEmployee.FlatAppearance.BorderSize = 0;
            this.buttonCreateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateEmployee.ForeColor = System.Drawing.Color.White;
            this.buttonCreateEmployee.Location = new System.Drawing.Point(42, 532);
            this.buttonCreateEmployee.Name = "buttonCreateEmployee";
            this.buttonCreateEmployee.Size = new System.Drawing.Size(133, 35);
            this.buttonCreateEmployee.TabIndex = 83;
            this.buttonCreateEmployee.Text = "Créer";
            this.buttonCreateEmployee.TextColor = System.Drawing.Color.White;
            this.buttonCreateEmployee.UseVisualStyleBackColor = false;
            this.buttonCreateEmployee.Click += new System.EventHandler(this.buttonCreateEmployee_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(549, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 25);
            this.label7.TabIndex = 84;
            this.label7.Text = "Créer un nouvel employé";
            // 
            // errorProviderUsername
            // 
            this.errorProviderUsername.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderUsername.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPassword.ContainerControl = this;
            // 
            // errorProviderLastName
            // 
            this.errorProviderLastName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderLastName.ContainerControl = this;
            // 
            // errorProviderFirstName
            // 
            this.errorProviderFirstName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFirstName.ContainerControl = this;
            // 
            // errorProviderBirthDate
            // 
            this.errorProviderBirthDate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderBirthDate.ContainerControl = this;
            // 
            // errorProviderCountry
            // 
            this.errorProviderCountry.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCountry.ContainerControl = this;
            // 
            // errorProviderConfirmPassword
            // 
            this.errorProviderConfirmPassword.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderConfirmPassword.ContainerControl = this;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 649);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonCreateEmployee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxShop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPasswordConfirmation);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBirthDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPasswordConfirmation;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxFirstName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxLastName;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker datePicker;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxCountry;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboBoxShop;
        private System.Windows.Forms.Label label6;
        private CustomControls.RJControls.RJButton buttonCreateEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProviderUsername;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
        private System.Windows.Forms.ErrorProvider errorProviderLastName;
        private System.Windows.Forms.ErrorProvider errorProviderFirstName;
        private System.Windows.Forms.ErrorProvider errorProviderBirthDate;
        private System.Windows.Forms.ErrorProvider errorProviderCountry;
        private System.Windows.Forms.ErrorProvider errorProviderConfirmPassword;
    }
}