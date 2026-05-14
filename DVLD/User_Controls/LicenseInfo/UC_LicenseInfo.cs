using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        // Method to set the Gender label
        public void SetLabelGender(string value)
        {
            Label_Variable_Gender.Text = value;
        }

        // Method to set the Issue Date
        public void SetLabelIssueDate(DateTime value)
        {
            Label_Variable_IssueDate.Text = value.ToShortDateString();
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

        // Method to set IsActive (Boolean to Text)
        public void SetLabelIsActive(bool isActive)
        {
            Label_Variable_IsActive.Text = isActive ? "Yes" : "No";
        }

        // Method to set Date of Birth
        public void SetLabelDateOfBirth(DateTime value)
        {
            Label_Variable_DateOfBirth.Text = value.ToShortDateString();
        }

        // Method to set Driver ID
        public void SetLabelDriverID(int value)
        {
            Label_Variable_DriverID.Text = value.ToString();
        }

        // Method to set Expiry Date
        public void SetLabelExpireDate(DateTime value)
        {
            Label_Variable_ExpireDate.Text = value.ToShortDateString();
        }

        // Method to set IsDetained (Boolean to Text)
        public void SetLabelIsDetained(bool isDetained)
        {
            Label_Variable_IsDetained.Text = isDetained ? "Yes" : "No";
        }
        #endregion End


        public void SetImage(Image image)
        {

            Pic_PersonImage.Image = image;

        }






    }
}
