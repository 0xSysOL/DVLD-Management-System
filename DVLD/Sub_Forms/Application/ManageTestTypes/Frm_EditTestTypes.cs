using DVLD_BussinessLogic.Application_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application.ManageTestTypes
{
    public partial class Frm_EditTestTypes : Form
    {
        clsManageTestTypes_BL clsManageTest;
        private void InitializeData(int ID)
        {
            clsManageTest = new clsManageTestTypes_BL(ID);

            Label_Variable_ID.Text = clsManageTest.GetID().ToString();
            TB_Title.Text = clsManageTest.GetTitle();
            TB_Descriptiion.Text = clsManageTest.GetDescription();
            TB_Fees.Text = clsManageTest.GetFees().ToString();

        }
        public Frm_EditTestTypes()
        {
            InitializeComponent(); 
        }
        public Frm_EditTestTypes(int ID) : this()
        {
            InitializeData(ID);
        }
        private void Frm_EditTestTypes_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (clsManageTest == null)
                return;

            if (!Utilities.Methods.IsDecimal(TB_Fees))
            {
                ErrorProvider.SetError(TB_Fees, "Please Enter Number");
                return;
            }else
                ErrorProvider.SetError(TB_Fees, "");




            clsManageTest.SetFees(Convert.ToDecimal(TB_Fees.Text));
            clsManageTest.SetTitle(TB_Title.Text);
            clsManageTest.SetDescription(TB_Descriptiion.Text);

            if (clsManageTest.Save())
                MessageBox.Show("Test Type Updated Successfully (:", "Info");
            else
                MessageBox.Show("Sorry Something Wrong Please Try Again ):", "Info",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
