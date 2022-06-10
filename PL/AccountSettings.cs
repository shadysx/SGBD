using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using CustomControls.RJControls;
using DTO;


namespace PL
{
    public partial class AccountSettings : Form
    {
        string fileName;
        byte[] profileImage;
        bool isImageLoad;

        public AccountSettings()
        {
            InitializeComponent();
            LoadCurrentUserInfo();

            this.labelAccountInfo.ForeColor = CustomColor.Orange;
            this.labelUsername.ForeColor = CustomColor.Orange;
            this.panelTopRight.BackColor = CustomColor.DarkBlue;
            this.panelBottom.BackColor = CustomColor.DarkBlue;
            this.panelTop.BackColor = CustomColor.DarkBlue;

            this.BackColor = CustomColor.DarkBlue;

            this.profileImage = BLLAccountSettings.SelectProfileImage(Auth.CurrentUser.ID_ACCOUNT);
            if (this.profileImage != null)
                this.pictureBox.Image = ConvertToImage(this.profileImage);

            this.isImageLoad = false;
        }

        private void LoadCurrentUserInfo()
        {
            this.labelUsername.Text = Auth.CurrentUser.ACCOUNT_USERNAME;
            this.labelLastNameInfo.Text = Auth.CurrentUser.ACCOUNT_LAST_NAME;
            this.labelFirstNameInfo.Text = Auth.CurrentUser.ACCOUNT_FIRST_NAME;
            this.labelEmailInfo.Text = Auth.CurrentUser.ACCOUNT_EMAIL;
            this.labelAddressInfo.Text = Auth.CurrentUser.ACCOUNT_ADDRESS;
            this.labelCityInfo.Text = Auth.CurrentUser.ACCOUNT_CITY;
            this.labelPostalCodeInfo.Text = Auth.CurrentUser.ACCOUNT_POSTAL_CODE;
            this.labelCountryInfo.Text = Auth.CurrentUser.ACCOUNT_COUNTRY;
            this.labelBirthDateInfo.Text = Auth.CurrentUser.ACCOUNT_BIRTH_DATE.ToString("dd-MM-yyyy");
        }

        private void buttonConfirmAccountSettings_Click(object sender, EventArgs e)
        {
            this.panelAccountUpdated.Visible = false;
            this.panelPasswordChange.Visible = false;

            bool isBookUnvalidate = false;
            bool isAddressNull = false;
            bool isCityNull = false;
            bool isCountryNull = false;
            bool isPostalCodeNull = false;

            ResetErrorProviderLeft();

            // Create Account with modify infos
            Account modifyAccount = Auth.CurrentUser;

            if (this.textBoxAddress.Texts.Trim() != "")
                modifyAccount.ACCOUNT_ADDRESS = this.textBoxAddress.Texts.Trim();
            else
                isAddressNull = true;

            if (this.textBoxCity.Texts.Trim() != "")
                modifyAccount.ACCOUNT_CITY = this.textBoxCity.Texts.Trim();
            else
                isCityNull = true;

            if (this.textBoxPostalCode.Texts != "")
                modifyAccount.ACCOUNT_POSTAL_CODE = this.textBoxPostalCode.Texts.Trim();
            else
                isPostalCodeNull = true;

            if (this.textBoxCountry.Texts.Trim() != "")
                modifyAccount.ACCOUNT_COUNTRY = this.textBoxCountry.Texts.Trim();
            else
                isCountryNull = true;

            // Use Rules Book Account
            RulesBookAccount rbAccount = new RulesBookAccount();

            var result = rbAccount.Validate(modifyAccount);

            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {
                    string s = failure.ErrorMessage;

                    if (!(failure.PropertyName.Contains("PASSWORD") || failure.PropertyName.Contains("EMAIL")))
                    {
                        if (failure.PropertyName.Contains("ADDRESS") && !isAddressNull)
                        {
                            this.errorProviderAddress.SetError(this.textBoxAddress, "Must contain at least between 1 and 249 char");
                            isBookUnvalidate = true;
                        }
                        else if (failure.PropertyName.Contains("CITY") && !isCityNull)
                        {
                            this.errorProviderCity.SetError(this.textBoxCity, "Must contain at least between 1 and 49 char");
                            isBookUnvalidate = true;
                        }
                        else if (failure.PropertyName.Contains("POSTAL_CODE") && s.Contains("format") & !isPostalCodeNull)
                        {
                            this.errorProviderPostalCode.SetError(this.textBoxPostalCode, "Unvalid Format");
                            isBookUnvalidate = true;
                        }
                        else if (failure.PropertyName.Contains("POSTAL_CODE") && s.Contains("caract") && isPostalCodeNull)
                        {
                            this.errorProviderPostalCode.SetError(this.textBoxPostalCode, "Must contain at least between 1 and 49 char");
                            isBookUnvalidate = true;
                        }
                        else if (failure.PropertyName.Contains("COUNTRY") && s.Contains("format") && !isCountryNull)
                        {
                            this.errorProviderCountry.SetError(this.textBoxCountry, "Unvalid Format");
                            isBookUnvalidate = true;
                        }
                        else if (failure.PropertyName.Contains("COUNTRY") && s.Contains("caract") && !isCountryNull)
                        {
                            this.errorProviderCountry.SetError(this.textBoxCountry, "Must contain at least between 1 and 49 char");
                            isBookUnvalidate = true;
                        }
                    }
                }
            }

            // Insert
            try
            {
                if (!isBookUnvalidate && !(isCountryNull && isCityNull && isAddressNull && isPostalCodeNull))
                {
                    BLL.DALRequest.InsertModifyAccount(modifyAccount);

                    foreach (RJTextBox tb in this.panelBottom.Controls.OfType<RJTextBox>())
                        tb.Texts = null;

                    this.panelAccountUpdated.Visible = true;

                    BLL.Auth.CurrentUser = modifyAccount;

                    LoadCurrentUserInfo();
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        private void buttonConfirmNewPassword_Click(object sender, EventArgs e)
        {
            bool error = false;
            this.panelPasswordChange.Visible = false;
            this.panelAccountUpdated.Visible = false;

            ResetErrorProviderRight();

            if (textBoxNewPassword.Texts.Length < 8 || textBoxNewPassword.Texts.Length > 49)
            {
                error = true;
                this.errorProviderNewPassword.SetError(textBoxNewPassword, "Must contain at least between 8 and 49 char !");
            }

            if (textBoxNewPassword.Texts != textBoxNewConfirmPassword.Texts)
            {
                error = true;
                this.errorProviderNewConfirmPassword.SetError(textBoxNewConfirmPassword, "Passwords are different !");
            }

            if (textBoxNewPassword.Texts == textBoxOldPassword.Texts)
            {
                error = true;
                this.errorProviderNewPassword.SetError(textBoxNewPassword, "Same as old password !");
            }


            if (Auth.ComputeSha256Hash(this.textBoxOldPassword.Texts) != Auth.CurrentUser.ACCOUNT_PASSWORD)
            {
                error = true;
                this.errorProviderOldPassword.SetError(textBoxOldPassword, "Wrong password !");
            }

            try
            {
                if (!error)
                {
                    BLL.DALRequest.UpdatePassword(Auth.ComputeSha256Hash(this.textBoxNewPassword.Texts), Auth.CurrentUser.ACCOUNT_USERNAME);
                    this.panelPasswordChange.Visible = true;

                    BLL.Auth.CurrentUser.ACCOUNT_PASSWORD = Auth.ComputeSha256Hash(this.textBoxNewPassword.Texts);

                    foreach (RJTextBox tb in this.panelBottom.Controls.OfType<RJTextBox>())
                        tb.Texts = null;
                }

            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }

        }

        private void ResetErrorProviderLeft()
        {
            this.errorProviderAddress.SetError(textBoxAddress, null);
            this.errorProviderCity.SetError(textBoxCity, null);
            this.errorProviderPostalCode.SetError(textBoxPostalCode, null);
            this.errorProviderCountry.SetError(textBoxCountry, null);
        }

        private void ResetErrorProviderRight()
        {
            this.errorProviderOldPassword.SetError(textBoxOldPassword, null);
            this.errorProviderNewPassword.SetError(textBoxNewPassword, null);
            this.errorProviderNewConfirmPassword.SetError(textBoxNewConfirmPassword, null);
        }
        

        private void buttonProfilePicture_Click(object sender, EventArgs e)
        {
            try
            {
                //Import image from pc to picturebox
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.pictureBox.ImageLocation = dialog.FileName.ToString();
                    var file = System.IO.Path.GetFileName(dialog.FileName);
                    this.fileName = file;
                    this.isImageLoad = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonConfirmProfilePicture_Click(object sender, EventArgs e)
        {
            if (this.pictureBox.Image != null && this.isImageLoad)
            {
                //Convert picture box image to byte array
                MemoryStream ms = new MemoryStream();
                pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] buff = ms.GetBuffer();

                if (this.profileImage == null)
                {                    
                    try
                    {
                        BLLAccountSettings.InsertProfileImage(this.fileName, Auth.CurrentUser.ID_ACCOUNT, buff);                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    try
                    {
                        BLLAccountSettings.ModifyProfileImage(this.fileName, Auth.CurrentUser.ID_ACCOUNT, buff);                        
                    }                    
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                MessageBox.Show("Profile's picture edited");

            }

        }

        public static Image ConvertToImage(Binary iBinary)
        {
            var arrayBinary = iBinary.ToArray();
            Image rImage = null;

            using (MemoryStream ms = new MemoryStream(arrayBinary))
            {
                rImage = Image.FromStream(ms);
            }
            return rImage;
        }
    }
}
