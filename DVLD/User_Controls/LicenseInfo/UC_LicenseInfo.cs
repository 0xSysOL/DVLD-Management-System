using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.User_Controls.LicenseInfo
{
    public partial class UC_LicenseInfo : UserControl
    {
        public UC_LicenseInfo()
        {
            InitializeComponent();
        }

        #region Labels

        public void RefreshLabels()
        {
            string Dots = "........................";
            SetLabelClass(Dots);
            SetLabelName(Dots);
            Label_Variable_LicenseID.Text = Dots;
            SetLabelGender(Dots);
            Label_Variable_IssueDate.Text = Dots;
            SetLabelIssueReason(Dots);
            SetLabelNote(Dots);
            Label_Variable_DateOfBirth.Text = Dots;
            Label_Variable_DriverID.Text = Dots;
            Label_Variable_ExpireDate.Text = Dots;
            SetLabelIsDetained(Dots);
            SetLabelIsActive(Dots);
            SetLabelNationalNo(Dots);

        }
        // Method to set the Class label
        public void SetLabelClass(string value)
        {
            Label_Variable_Class.Text = value;
        }

        // Method to set the Name label
        public void SetLabelName(string value)
        {
            Label_Variable_Name.Text = value;
        }

        // Method to set the License ID label
        public void SetLabelLicenseID(int value)
        {
            Label_Variable_LicenseID.Text = value.ToString();
        }
        public int GetLabelLicenseID()
        {

            return Convert.ToInt32(Label_Variable_LicenseID.Text);

        }

        // Method to set the Gender label
        public void SetLabelGender(string value)
        {
            Label_Variable_Gender.Text = value;
        }

        // Method to set the Issue Date
        public void SetLabelIssueDate(DateTime value)
        {
            Label_Variable_IssueDate.Text = value.ToString("dd/MMM/yyyy");
        }

        // Method to set the Issue Reason
        public void SetLabelIssueReason(string value)
        {
            Label_Variable_IssueReason.Text = value;
        }

        // Method to set the Note
        public void SetLabelNote(string value)
        {
            Label_Variable_Note.Text = string.IsNullOrEmpty(value) ? "No Notes" : value;
        }

        // Method to set IsActive string
        public void SetLabelIsActive(string isActive)
        {
            Label_Variable_IsActive.Text = isActive;

        }

        // Method to set Date of Birth
        public void SetLabelDateOfBirth(DateTime value)
        {

            Label_Variable_DateOfBirth.Text = value.ToString("dd/MMM/yyyy");
        }

        // Method to set Driver ID
        public void SetLabelDriverID(int value)
        {
            Label_Variable_DriverID.Text = value.ToString();
        }
        public int GetLabelDriverID()
        {

            return Convert.ToInt32(Label_Variable_DriverID.Text);

        }
        // Method to set Expiry Date
        public void SetLabelExpireDate(DateTime value)
        {
            Label_Variable_ExpireDate.Text = value.ToString("dd/MMM/yyyy");
        }
        public void SetLabelNationalNo(string NationalNo)
        {
            Label_Variable_NationalNO.Text = NationalNo;

        }

        public void SetLabelIsDetained(string IsDetained)
        {

            Label_Variable_IsDetained.Text = IsDetained;
        }
        #endregion End


        public void SetImage(Image image)
        {

            Pic_PersonImage.Image = image;

        }

        private void Person_Card_Enter(object sender, EventArgs e)
        {

        }
    }
}
