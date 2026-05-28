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
    public partial class Int_LicenseInfo : UserControl
    {
        public Int_LicenseInfo()
        {
            InitializeComponent();
        }

        private void Person_Card_Enter(object sender, EventArgs e)
        {

        }
        // 1. Name
        public void Set_Label_Variable_Name(string value)
        {
            Label_Variable_Name.Text = value;
        }

        // 2. License ID
        public void Set_Label_Variable_LicenseID(string value)
        {
            Label_Variable_LicenseID.Text = value;
        }

        // 3. Int.License ID
        public void Set_Label_Variable_IntLicenseID(string value)
        {
            Label_Variable_Int_LicenseID.Text = value;
        }

        // 4. NationalNo
        public void Set_Label_Variable_NationalNo(string value)
        {
            Label_Variable_NationalNO.Text = value;
        }

        // 5. Gender
        public void Set_Label_Variable_Gender(string value)
        {
            Label_Variable_Gender.Text = value;
        }

        // 6. Issue Date
        public void Set_Label_Variable_IssueDate(string value)
        {
            Label_Variable_IssueDate.Text = value;
        }

        // 7. Application ID
        public void Set_Label_Variable_ApplicationID(string value)
        {
            Label_Variable_ApplicationID.Text = value;
        }

        // 8. Is Active
        public void Set_Label_Variable_IsActive(string value)
        {
            Label_Variable_IsActive.Text = value;
        }

        // 9. Date Of Birth
        public void Set_Label_Variable_DateOfBirth(string value)
        {
            Label_Variable_DateOfBirth.Text = value;
        }

        // 10. Driver ID
        public void Set_Label_Variable_DriverID(string value)
        {
            Label_Variable_DriverID.Text = value;
        }

        // 11. Expier Date
        public void Set_Label_Variable_ExpierDate(string value)
        {
            Label_Variable_ExpireDate.Text = value;
        }



        public void Set_Pic_Person(Image image)
        {

            Pic_PersonImage.Image = image;
        }



    }
}
