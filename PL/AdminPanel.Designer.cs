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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCreateShop = new CustomControls.RJControls.RJButton();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxShopCity = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxShopCountry = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.textBoxShopPostal = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxShopAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxShopName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.labelShopName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBirthDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPassword)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Créer un nouvel employé";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(26, 84);
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
            this.labelEmail.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(21, 56);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(74, 37);
            this.labelEmail.TabIndex = 66;
            this.labelEmail.Text = "Email";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(21, 117);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(189, 37);
            this.labelUserName.TabIndex = 67;
            this.labelUserName.Text = "Nom de compte";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(21, 196);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(158, 37);
            this.labelPassword.TabIndex = 68;
            this.labelPassword.Text = "Mot de passe";
            // 
            // labelPasswordConfirmation
            // 
            this.labelPasswordConfirmation.AutoSize = true;
            this.labelPasswordConfirmation.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordConfirmation.ForeColor = System.Drawing.Color.White;
            this.labelPasswordConfirmation.Location = new System.Drawing.Point(230, 196);
            this.labelPasswordConfirmation.Name = "labelPasswordConfirmation";
            this.labelPasswordConfirmation.Size = new System.Drawing.Size(154, 37);
            this.labelPasswordConfirmation.TabIndex = 69;
            this.labelPasswordConfirmation.Text = "Confirmation";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(26, 157);
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
            this.textBoxPassword.Location = new System.Drawing.Point(26, 236);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
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
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(237, 236);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '*';
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
            this.label2.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(228, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 37);
            this.label2.TabIndex = 73;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 37);
            this.label3.TabIndex = 74;
            this.label3.Text = "Nom";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(235, 323);
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
            this.textBoxLastName.Location = new System.Drawing.Point(26, 323);
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
            this.datePicker.Location = new System.Drawing.Point(28, 396);
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
            this.label4.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 37);
            this.label4.TabIndex = 78;
            this.label4.Text = "Date de naissance";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(233, 397);
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
            this.label5.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(230, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 37);
            this.label5.TabIndex = 80;
            this.label5.Text = "Pays";
            // 
            // comboBoxShop
            // 
            this.comboBoxShop.DropDownWidth = 180;
            this.comboBoxShop.Location = new System.Drawing.Point(522, 396);
            this.comboBoxShop.Name = "comboBoxShop";
            this.comboBoxShop.Size = new System.Drawing.Size(181, 29);
            this.comboBoxShop.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboBoxShop.StateCommon.ComboBox.Border.Rounding = 12;
            this.comboBoxShop.TabIndex = 81;
            this.comboBoxShop.Text = "kryptonComboBox1";
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
            this.buttonCreateEmployee.Location = new System.Drawing.Point(26, 523);
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
            this.label7.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(510, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(316, 37);
            this.label7.TabIndex = 84;
            this.label7.Text = "Créer un nouveeau magasin";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.buttonCreateShop);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBoxShop);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.buttonCreateEmployee);
            this.panel1.Controls.Add(this.textBoxShopCity);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBoxShopCountry);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelPostalCode);
            this.panel1.Controls.Add(this.textBoxCountry);
            this.panel1.Controls.Add(this.textBoxShopPostal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxShopAddress);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxLastName);
            this.panel1.Controls.Add(this.textBoxShopName);
            this.panel1.Controls.Add(this.textBoxFirstName);
            this.panel1.Controls.Add(this.labelShopName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxConfirmPassword);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.labelUserName);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.labelPasswordConfirmation);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 571);
            this.panel1.TabIndex = 85;
            // 
            // buttonCreateShop
            // 
            this.buttonCreateShop.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCreateShop.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCreateShop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCreateShop.BorderRadius = 12;
            this.buttonCreateShop.BorderSize = 0;
            this.buttonCreateShop.FlatAppearance.BorderSize = 0;
            this.buttonCreateShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateShop.ForeColor = System.Drawing.Color.White;
            this.buttonCreateShop.Location = new System.Drawing.Point(515, 523);
            this.buttonCreateShop.Name = "buttonCreateShop";
            this.buttonCreateShop.Size = new System.Drawing.Size(133, 35);
            this.buttonCreateShop.TabIndex = 95;
            this.buttonCreateShop.Text = "Créer";
            this.buttonCreateShop.TextColor = System.Drawing.Color.White;
            this.buttonCreateShop.UseVisualStyleBackColor = false;
            this.buttonCreateShop.Click += new System.EventHandler(this.buttonCreateShop_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(510, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 37);
            this.label10.TabIndex = 93;
            this.label10.Text = "Ville";
            // 
            // textBoxShopCity
            // 
            this.textBoxShopCity.Location = new System.Drawing.Point(515, 315);
            this.textBoxShopCity.Name = "textBoxShopCity";
            this.textBoxShopCity.Size = new System.Drawing.Size(188, 28);
            this.textBoxShopCity.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxShopCity.StateCommon.Border.Rounding = 12;
            this.textBoxShopCity.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxShopCity.TabIndex = 94;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(510, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 37);
            this.label9.TabIndex = 91;
            this.label9.Text = "Pays";
            // 
            // textBoxShopCountry
            // 
            this.textBoxShopCountry.Location = new System.Drawing.Point(515, 236);
            this.textBoxShopCountry.Name = "textBoxShopCountry";
            this.textBoxShopCountry.Size = new System.Drawing.Size(188, 28);
            this.textBoxShopCountry.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxShopCountry.StateCommon.Border.Rounding = 12;
            this.textBoxShopCountry.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxShopCountry.TabIndex = 92;
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostalCode.ForeColor = System.Drawing.Color.White;
            this.labelPostalCode.Location = new System.Drawing.Point(717, 196);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(144, 37);
            this.labelPostalCode.TabIndex = 89;
            this.labelPostalCode.Text = "Code postal";
            // 
            // textBoxShopPostal
            // 
            this.textBoxShopPostal.Location = new System.Drawing.Point(724, 236);
            this.textBoxShopPostal.Name = "textBoxShopPostal";
            this.textBoxShopPostal.Size = new System.Drawing.Size(188, 28);
            this.textBoxShopPostal.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxShopPostal.StateCommon.Border.Rounding = 12;
            this.textBoxShopPostal.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxShopPostal.TabIndex = 90;
            // 
            // textBoxShopAddress
            // 
            this.textBoxShopAddress.Location = new System.Drawing.Point(515, 157);
            this.textBoxShopAddress.Name = "textBoxShopAddress";
            this.textBoxShopAddress.Size = new System.Drawing.Size(395, 28);
            this.textBoxShopAddress.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxShopAddress.StateCommon.Border.Rounding = 12;
            this.textBoxShopAddress.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxShopAddress.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(510, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 37);
            this.label8.TabIndex = 88;
            this.label8.Text = "Adresse ";
            // 
            // textBoxShopName
            // 
            this.textBoxShopName.Location = new System.Drawing.Point(515, 86);
            this.textBoxShopName.Name = "textBoxShopName";
            this.textBoxShopName.Size = new System.Drawing.Size(395, 28);
            this.textBoxShopName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxShopName.StateCommon.Border.Rounding = 12;
            this.textBoxShopName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxShopName.TabIndex = 85;
            // 
            // labelShopName
            // 
            this.labelShopName.AutoSize = true;
            this.labelShopName.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShopName.ForeColor = System.Drawing.Color.White;
            this.labelShopName.Location = new System.Drawing.Point(510, 48);
            this.labelShopName.Name = "labelShopName";
            this.labelShopName.Size = new System.Drawing.Size(199, 37);
            this.labelShopName.TabIndex = 86;
            this.labelShopName.Text = "Nom du magasin";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1621, 1192);
            this.flowLayoutPanel1.TabIndex = 86;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.kryptonComboBox1);
            this.panel2.Controls.Add(this.kryptonTextBox1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(3, 580);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 571);
            this.panel2.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(21, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 37);
            this.label11.TabIndex = 96;
            this.label11.Text = "Modifier un utilisateur";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(791, 157);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(168, 28);
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.Rounding = 12;
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.TabIndex = 96;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(788, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 37);
            this.label12.TabIndex = 96;
            this.label12.Text = "Rechercher Par";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropDownWidth = 180;
            this.kryptonComboBox1.Location = new System.Drawing.Point(791, 103);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(168, 29);
            this.kryptonComboBox1.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox1.StateCommon.ComboBox.Border.Rounding = 12;
            this.kryptonComboBox1.TabIndex = 96;
            this.kryptonComboBox1.Text = "kryptonComboBox1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(517, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 37);
            this.label13.TabIndex = 97;
            this.label13.Text = "Magasin";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 12;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(792, 211);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(133, 35);
            this.rjButton1.TabIndex = 98;
            this.rjButton1.Text = "Appliquer";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(28, 66);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(720, 458);
            this.flowLayoutPanel2.TabIndex = 99;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(DTO.Account);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 1192);
            this.Controls.Add(this.flowLayoutPanel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton buttonCreateShop;
        private System.Windows.Forms.Label label10;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxShopCity;
        private System.Windows.Forms.Label label9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxShopCountry;
        private System.Windows.Forms.Label labelPostalCode;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxShopPostal;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxShopAddress;
        private System.Windows.Forms.Label label8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxShopName;
        private System.Windows.Forms.Label labelShopName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private System.Windows.Forms.Label label12;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private System.Windows.Forms.Label label13;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}