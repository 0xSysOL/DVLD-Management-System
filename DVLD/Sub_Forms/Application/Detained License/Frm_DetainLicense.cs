using DVLD.Sub_Forms.Drivers;
using DVLD.Sub_Forms.License;
using DVLD.User_Controls.Detain;
using DVLD_BussinessLogic.Detained;
using DVLD_BussinessLogic.License_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application.Detained_License
{
    public partial class Frm_DetainLicense : Form
    {
        int _LicenseID;
        public Frm_DetainLicense()
        {
            InitializeComponent();
            EnableBtnDet(false);
            EnableShowLicenseHis(false);
            EnableShowLicenseInfo(false);
            _LicenseID = -1;
        }

        private void Frm_DetainLicense_Load(object sender, EventArgs e)
        {

        }
        private void EnableBtnDet(bool Key)
        {
            Btn_Detain.Enabled = Key;
        }
        private void EnableShowLicenseHis(bool Key)
        {
            LinkLabel_LicenseHistory.Enabled = Key;
        }
        private void EnableShowLicenseInfo(bool Key)
        {
            LinkLabel_LicenseInfo.Enabled = Key;

        }
        private void UC_LicenseFilter_evSendResult(int LicenseID)
        {

            if (Utilities.Methods.Fill_UC_LicenseInfo(UC_LicenseInfo, LicenseID, "LicenseID"))
            {
                EnableBtnDet(true);
                EnableShowLicenseHis(true);
                EnableShowLicenseInfo(true);
                UC_DetainInfo.SetLicenseID(LicenseID);
                _LicenseID = LicenseID;
            }
            else
            {
                EnableBtnDet(false);
                EnableShowLicenseHis(false);
                EnableShowLicenseInfo(false);
                UC_DetainInfo.SetLicenseID(-1);

                _LicenseID = -1;
            }
        }

        private void Btn_Detain_Click(object sender, EventArgs e)
        {
            decimal FineFees = UC_DetainInfo.GetDineFees();
            if (FineFees <= 0)
            {
                MessageBox.Show("You Should Add Detain Fees To Completing Detain Information", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            if (Utilities.Methods.IsLicenseDetain(_LicenseID))
                return;


            clsDetained_BL clsDetained_ = new clsDetained_BL(_LicenseID, FineFees);

            if (clsDetained_.Save())
            {
                UC_DetainInfo.SetDetainID(clsDetained_.GetDetainID());
                MessageBox.Show("Detain Added Successfully", "Info",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
                MessageBox.Show("Something Wrong Please Try Again!!", "Info",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void LinkLabel_LicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int PersonID = clsLicense_BL.GetPersonIDByLicenseID(_LicenseID);
            Frm_ShowPersonLicenseHistory SPLH = new Frm_ShowPersonLicenseHistory(PersonID, "Person");

            SPLH.ShowDialog();
        }

        private void LinkLabel_LicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_DrivingLicenseInfo DLI = new Frm_DrivingLicenseInfo(_LicenseID,"LicenseID");

            DLI.ShowDialog();

        }



    }



}
