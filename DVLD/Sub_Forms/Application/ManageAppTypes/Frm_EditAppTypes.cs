using DVLD_BussinessLogic.Application_Classes;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Application.ManageAppTypes
{
    public partial class Frm_EditAppTypes : Form
    {
        clsManageApplicationTypes_BL RecordAppType;

        private void InitializeData(int ID)
        {


            RecordAppType = new clsManageApplicationTypes_BL(ID);
            Label_Variable_ID.Text = RecordAppType.GetID().ToString();
            TB_Title.Text = RecordAppType.GetTitle();
            TB_Fees.Text = RecordAppType.GetFees().ToString();

        }
        public Frm_EditAppTypes()
        {
            InitializeComponent();
        }
        public Frm_EditAppTypes(int ID) : this()
        {

            InitializeData(ID);
        }
        private void Frm_EditAppTypes_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {

            if (!TB_Fees.Text.All(c => char.IsDigit(c) || c == '.'))
            {


                ErrorProvider.SetError(TB_Fees, "Please Enter Number");
                return;
            }else
                ErrorProvider.SetError(TB_Fees, "");


            RecordAppType.SetTitle(TB_Title.Text);
            RecordAppType.SetFees(Convert.ToDecimal(TB_Fees.Text));

            if (RecordAppType.Save())
            MessageBox.Show("Application Type Updated Successfully", "Info");
            

        }

        private void TB_Fees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }


        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
