namespace PL
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.buttonCancel = new CustomControls.RJControls.RJButton();
            this.pictureBoxNewCustomer = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new CustomControls.RJControls.RJTextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.buttonSubmit = new CustomControls.RJControls.RJButton();
            this.textBoxUsername = new CustomControls.RJControls.RJTextBox();
            this.labelPasswordConfirm = new System.Windows.Forms.Label();
            this.datePicker = new CustomControls.RJControls.RJDatePicker();
            this.textBoxPassword = new CustomControls.RJControls.RJTextBox();
            this.textBoxConfirmPassword = new CustomControls.RJControls.RJTextBox();
            this.textBoxLastName = new CustomControls.RJControls.RJTextBox();
            this.textBoxFirstName = new CustomControls.RJControls.RJTextBox();
            this.textBoxAddress = new CustomControls.RJControls.RJTextBox();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.textBoxCountry = new CustomControls.RJControls.RJTextBox();
            this.textBoxCity = new CustomControls.RJControls.RJTextBox();
            this.textBoxPostalCode = new CustomControls.RJControls.RJTextBox();
            this.buttonSelectProfileImage = new CustomControls.RJControls.RJButton();
            this.labelIcon = new System.Windows.Forms.Label();
            this.errorProviderUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderBirthDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPostalCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCountry = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelSuccess = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSuccess = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBirthDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPostalCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            this.panelSuccess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLeft.Controls.Add(this.panelSuccess);
            this.panelLeft.Controls.Add(this.panelRight);
            this.panelLeft.Controls.Add(this.buttonCancel);
            this.panelLeft.Controls.Add(this.pictureBoxNewCustomer);
            this.panelLeft.Controls.Add(this.pictureBoxLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(225, 450);
            this.panelLeft.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.Control;
            this.panelRight.Location = new System.Drawing.Point(231, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(566, 446);
            this.panelRight.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCancel.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCancel.BorderRadius = 15;
            this.buttonCancel.BorderSize = 0;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(12, 405);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 33);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.TextColor = System.Drawing.Color.White;
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // pictureBoxNewCustomer
            // 
            this.pictureBoxNewCustomer.BackgroundImage = global::PL.Properties.Resources.New_Custommer_Logo;
            this.pictureBoxNewCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxNewCustomer.Location = new System.Drawing.Point(29, 144);
            this.pictureBoxNewCustomer.Name = "pictureBoxNewCustomer";
            this.pictureBoxNewCustomer.Size = new System.Drawing.Size(163, 149);
            this.pictureBoxNewCustomer.TabIndex = 1;
            this.pictureBoxNewCustomer.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::PL.Properties.Resources.Stock_Overflow1;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 11);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(193, 54);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Black;
            this.labelEmail.Location = new System.Drawing.Point(234, 25);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(57, 28);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEmail.BorderColor = System.Drawing.Color.Black;
            this.textBoxEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxEmail.BorderRadius = 15;
            this.textBoxEmail.BorderSize = 2;
            this.textBoxEmail.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxEmail.Location = new System.Drawing.Point(332, 19);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Multiline = false;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxEmail.PasswordChar = false;
            this.textBoxEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxEmail.PlaceholderText = "";
            this.textBoxEmail.Size = new System.Drawing.Size(447, 34);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.Texts = "";
            this.textBoxEmail.UnderlinedStyle = false;
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Black;
            this.labelUsername.Location = new System.Drawing.Point(234, 71);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(97, 28);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Black;
            this.labelPassword.Location = new System.Drawing.Point(520, 71);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(92, 28);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.Color.Black;
            this.labelFirstName.Location = new System.Drawing.Point(234, 165);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(99, 28);
            this.labelFirstName.TabIndex = 7;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.ForeColor = System.Drawing.Color.Black;
            this.labelLastName.Location = new System.Drawing.Point(512, 165);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(99, 28);
            this.labelLastName.TabIndex = 8;
            this.labelLastName.Text = "Last Name";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.Black;
            this.labelAddress.Location = new System.Drawing.Point(234, 270);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(79, 28);
            this.labelAddress.TabIndex = 11;
            this.labelAddress.Text = "Address";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.ForeColor = System.Drawing.Color.Black;
            this.labelCountry.Location = new System.Drawing.Point(234, 377);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(78, 28);
            this.labelCountry.TabIndex = 13;
            this.labelCountry.Text = "Country";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.ForeColor = System.Drawing.Color.Black;
            this.labelCity.Location = new System.Drawing.Point(234, 322);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(44, 28);
            this.labelCity.TabIndex = 15;
            this.labelCity.Text = "City";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostalCode.ForeColor = System.Drawing.Color.Black;
            this.labelPostalCode.Location = new System.Drawing.Point(553, 322);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(109, 28);
            this.labelPostalCode.TabIndex = 17;
            this.labelPostalCode.Text = "Postal Code";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonSubmit.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonSubmit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSubmit.BorderRadius = 15;
            this.buttonSubmit.BorderSize = 0;
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(658, 405);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(126, 33);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.TextColor = System.Drawing.Color.White;
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUsername.BorderColor = System.Drawing.Color.Black;
            this.textBoxUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxUsername.BorderRadius = 15;
            this.textBoxUsername.BorderSize = 2;
            this.textBoxUsername.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxUsername.Location = new System.Drawing.Point(332, 65);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Multiline = false;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxUsername.PasswordChar = false;
            this.textBoxUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxUsername.PlaceholderText = "";
            this.textBoxUsername.Size = new System.Drawing.Size(172, 34);
            this.textBoxUsername.TabIndex = 19;
            this.textBoxUsername.Texts = "";
            this.textBoxUsername.UnderlinedStyle = false;
            // 
            // labelPasswordConfirm
            // 
            this.labelPasswordConfirm.AutoSize = true;
            this.labelPasswordConfirm.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordConfirm.ForeColor = System.Drawing.Color.Black;
            this.labelPasswordConfirm.Location = new System.Drawing.Point(450, 116);
            this.labelPasswordConfirm.Name = "labelPasswordConfirm";
            this.labelPasswordConfirm.Size = new System.Drawing.Size(162, 28);
            this.labelPasswordConfirm.TabIndex = 22;
            this.labelPasswordConfirm.Text = "Confirm Password";
            // 
            // datePicker
            // 
            this.datePicker.BorderColor = System.Drawing.Color.Black;
            this.datePicker.BorderSize = 2;
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePicker.Location = new System.Drawing.Point(332, 209);
            this.datePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(186, 35);
            this.datePicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.datePicker.TabIndex = 23;
            this.datePicker.TextColor = System.Drawing.Color.White;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassword.BorderColor = System.Drawing.Color.Black;
            this.textBoxPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxPassword.BorderRadius = 15;
            this.textBoxPassword.BorderSize = 2;
            this.textBoxPassword.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPassword.Location = new System.Drawing.Point(612, 65);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxPassword.PasswordChar = false;
            this.textBoxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPassword.PlaceholderText = "";
            this.textBoxPassword.Size = new System.Drawing.Size(167, 34);
            this.textBoxPassword.TabIndex = 26;
            this.textBoxPassword.Texts = "";
            this.textBoxPassword.UnderlinedStyle = false;
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxConfirmPassword.BorderColor = System.Drawing.Color.Black;
            this.textBoxConfirmPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxConfirmPassword.BorderRadius = 15;
            this.textBoxConfirmPassword.BorderSize = 2;
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(612, 111);
            this.textBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfirmPassword.Multiline = false;
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxConfirmPassword.PasswordChar = false;
            this.textBoxConfirmPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxConfirmPassword.PlaceholderText = "";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(167, 34);
            this.textBoxConfirmPassword.TabIndex = 27;
            this.textBoxConfirmPassword.Texts = "";
            this.textBoxConfirmPassword.UnderlinedStyle = false;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLastName.BorderColor = System.Drawing.Color.Black;
            this.textBoxLastName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxLastName.BorderRadius = 15;
            this.textBoxLastName.BorderSize = 2;
            this.textBoxLastName.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxLastName.Location = new System.Drawing.Point(612, 159);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastName.Multiline = false;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxLastName.PasswordChar = false;
            this.textBoxLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxLastName.PlaceholderText = "";
            this.textBoxLastName.Size = new System.Drawing.Size(167, 34);
            this.textBoxLastName.TabIndex = 28;
            this.textBoxLastName.Texts = "";
            this.textBoxLastName.UnderlinedStyle = false;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFirstName.BorderColor = System.Drawing.Color.Black;
            this.textBoxFirstName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxFirstName.BorderRadius = 15;
            this.textBoxFirstName.BorderSize = 2;
            this.textBoxFirstName.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxFirstName.Location = new System.Drawing.Point(332, 159);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstName.Multiline = false;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxFirstName.PasswordChar = false;
            this.textBoxFirstName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxFirstName.PlaceholderText = "";
            this.textBoxFirstName.Size = new System.Drawing.Size(172, 34);
            this.textBoxFirstName.TabIndex = 29;
            this.textBoxFirstName.Texts = "";
            this.textBoxFirstName.UnderlinedStyle = false;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxAddress.BorderColor = System.Drawing.Color.Black;
            this.textBoxAddress.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxAddress.BorderRadius = 15;
            this.textBoxAddress.BorderSize = 2;
            this.textBoxAddress.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxAddress.Location = new System.Drawing.Point(332, 264);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddress.Multiline = false;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxAddress.PasswordChar = false;
            this.textBoxAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxAddress.PlaceholderText = "";
            this.textBoxAddress.Size = new System.Drawing.Size(447, 34);
            this.textBoxAddress.TabIndex = 30;
            this.textBoxAddress.Texts = "";
            this.textBoxAddress.UnderlinedStyle = false;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDate.ForeColor = System.Drawing.Color.Black;
            this.labelBirthDate.Location = new System.Drawing.Point(234, 218);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(91, 28);
            this.labelBirthDate.TabIndex = 31;
            this.labelBirthDate.Text = "Birth Date";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCountry.BorderColor = System.Drawing.Color.Black;
            this.textBoxCountry.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxCountry.BorderRadius = 15;
            this.textBoxCountry.BorderSize = 2;
            this.textBoxCountry.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCountry.Location = new System.Drawing.Point(332, 371);
            this.textBoxCountry.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCountry.Multiline = false;
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxCountry.PasswordChar = false;
            this.textBoxCountry.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxCountry.PlaceholderText = "";
            this.textBoxCountry.Size = new System.Drawing.Size(172, 34);
            this.textBoxCountry.TabIndex = 32;
            this.textBoxCountry.Texts = "";
            this.textBoxCountry.UnderlinedStyle = false;
            // 
            // textBoxCity
            // 
            this.textBoxCity.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCity.BorderColor = System.Drawing.Color.Black;
            this.textBoxCity.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxCity.BorderRadius = 15;
            this.textBoxCity.BorderSize = 2;
            this.textBoxCity.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCity.Location = new System.Drawing.Point(332, 316);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCity.Multiline = false;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxCity.PasswordChar = false;
            this.textBoxCity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxCity.PlaceholderText = "";
            this.textBoxCity.Size = new System.Drawing.Size(172, 34);
            this.textBoxCity.TabIndex = 33;
            this.textBoxCity.Texts = "";
            this.textBoxCity.UnderlinedStyle = false;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPostalCode.BorderColor = System.Drawing.Color.Black;
            this.textBoxPostalCode.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxPostalCode.BorderRadius = 15;
            this.textBoxPostalCode.BorderSize = 2;
            this.textBoxPostalCode.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPostalCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPostalCode.Location = new System.Drawing.Point(679, 316);
            this.textBoxPostalCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPostalCode.Multiline = false;
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBoxPostalCode.PasswordChar = false;
            this.textBoxPostalCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPostalCode.PlaceholderText = "";
            this.textBoxPostalCode.Size = new System.Drawing.Size(100, 34);
            this.textBoxPostalCode.TabIndex = 34;
            this.textBoxPostalCode.Texts = "";
            this.textBoxPostalCode.UnderlinedStyle = false;
            // 
            // buttonSelectProfileImage
            // 
            this.buttonSelectProfileImage.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonSelectProfileImage.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonSelectProfileImage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSelectProfileImage.BorderRadius = 10;
            this.buttonSelectProfileImage.BorderSize = 0;
            this.buttonSelectProfileImage.FlatAppearance.BorderSize = 0;
            this.buttonSelectProfileImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSelectProfileImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectProfileImage.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectProfileImage.ForeColor = System.Drawing.Color.White;
            this.buttonSelectProfileImage.Location = new System.Drawing.Point(353, 113);
            this.buttonSelectProfileImage.Name = "buttonSelectProfileImage";
            this.buttonSelectProfileImage.Size = new System.Drawing.Size(91, 32);
            this.buttonSelectProfileImage.TabIndex = 35;
            this.buttonSelectProfileImage.Text = "Select...";
            this.buttonSelectProfileImage.TextColor = System.Drawing.Color.White;
            this.buttonSelectProfileImage.UseVisualStyleBackColor = false;
            this.buttonSelectProfileImage.Click += new System.EventHandler(this.buttonSelectProfileImage_Click);
            // 
            // labelIcon
            // 
            this.labelIcon.AutoSize = true;
            this.labelIcon.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIcon.ForeColor = System.Drawing.Color.Black;
            this.labelIcon.Location = new System.Drawing.Point(234, 116);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(113, 28);
            this.labelIcon.TabIndex = 36;
            this.labelIcon.Text = "Profile\'s Icon";
            // 
            // errorProviderUsername
            // 
            this.errorProviderUsername.BlinkRate = 0;
            this.errorProviderUsername.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderUsername.ContainerControl = this;
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.BlinkRate = 0;
            this.errorProviderPassword.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPassword.ContainerControl = this;
            // 
            // errorProviderConfirmPassword
            // 
            this.errorProviderConfirmPassword.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderConfirmPassword.ContainerControl = this;
            // 
            // errorProviderFirstName
            // 
            this.errorProviderFirstName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFirstName.ContainerControl = this;
            // 
            // errorProviderLastName
            // 
            this.errorProviderLastName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderLastName.ContainerControl = this;
            // 
            // errorProviderBirthDate
            // 
            this.errorProviderBirthDate.BlinkRate = 0;
            this.errorProviderBirthDate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderBirthDate.ContainerControl = this;
            // 
            // errorProviderAddress
            // 
            this.errorProviderAddress.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderAddress.ContainerControl = this;
            // 
            // errorProviderCity
            // 
            this.errorProviderCity.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCity.ContainerControl = this;
            // 
            // errorProviderPostalCode
            // 
            this.errorProviderPostalCode.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderPostalCode.ContainerControl = this;
            // 
            // errorProviderCountry
            // 
            this.errorProviderCountry.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderCountry.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderEmail.ContainerControl = this;
            // 
            // panelSuccess
            // 
            this.panelSuccess.Controls.Add(this.labelSuccess);
            this.panelSuccess.Controls.Add(this.pictureBox1);
            this.panelSuccess.Location = new System.Drawing.Point(10, 322);
            this.panelSuccess.Name = "panelSuccess";
            this.panelSuccess.Size = new System.Drawing.Size(204, 62);
            this.panelSuccess.TabIndex = 3;
            this.panelSuccess.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 45);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuccess.Location = new System.Drawing.Point(59, 22);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(139, 19);
            this.labelSuccess.TabIndex = 1;
            this.labelSuccess.Text = "Registration Successful";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelIcon);
            this.Controls.Add(this.buttonSelectProfileImage);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.labelPasswordConfirm);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.StateCommon.Border.Rounding = 15;
            this.Text = "Registration";
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBirthDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPostalCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            this.panelSuccess.ResumeLayout(false);
            this.panelSuccess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxNewCustomer;
        private CustomControls.RJControls.RJButton buttonCancel;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelEmail;
        private CustomControls.RJControls.RJTextBox textBoxEmail;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelPostalCode;
        private CustomControls.RJControls.RJButton buttonSubmit;
        private CustomControls.RJControls.RJTextBox textBoxUsername;
        private System.Windows.Forms.Label labelPasswordConfirm;
        private CustomControls.RJControls.RJDatePicker datePicker;
        private CustomControls.RJControls.RJTextBox textBoxPassword;
        private CustomControls.RJControls.RJTextBox textBoxConfirmPassword;
        private CustomControls.RJControls.RJTextBox textBoxLastName;
        private CustomControls.RJControls.RJTextBox textBoxFirstName;
        private CustomControls.RJControls.RJTextBox textBoxAddress;
        private System.Windows.Forms.Label labelBirthDate;
        private CustomControls.RJControls.RJTextBox textBoxCountry;
        private CustomControls.RJControls.RJTextBox textBoxCity;
        private CustomControls.RJControls.RJTextBox textBoxPostalCode;
        private CustomControls.RJControls.RJButton buttonSelectProfileImage;
        private System.Windows.Forms.Label labelIcon;
        private System.Windows.Forms.ErrorProvider errorProviderUsername;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
        private System.Windows.Forms.ErrorProvider errorProviderConfirmPassword;
        private System.Windows.Forms.ErrorProvider errorProviderFirstName;
        private System.Windows.Forms.ErrorProvider errorProviderLastName;
        private System.Windows.Forms.ErrorProvider errorProviderBirthDate;
        private System.Windows.Forms.ErrorProvider errorProviderAddress;
        private System.Windows.Forms.ErrorProvider errorProviderCity;
        private System.Windows.Forms.ErrorProvider errorProviderPostalCode;
        private System.Windows.Forms.ErrorProvider errorProviderCountry;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.Panel panelSuccess;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSuccess;
    }
}