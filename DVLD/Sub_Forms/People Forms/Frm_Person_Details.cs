using DVLD.Sub_Forms.People_Forms;
using DVLD_BusinessLogic;
using System;
using System.Windows.Forms;

namespace DVLD.Sub_Forms
{
    public partial class Frm_Person_Details : Form
    {
        clsPeople_BL clsPeople_;

        private void InitializeDataMembers(int ID)
        {
            clsPeople_ = new clsPeople_BL(ID);

        }

        public Frm_Person_Details(int ID)
        {
            InitializeComponent();
            InitializeDataMembers(ID);
        }








        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Person_Details_Load(object sender, EventArgs e)
        {
            Utilities.Methods.Fill_UC_Controls(uC_ShowPersonInfo1, clsPeople_);
        }

        private void uC_ShowPersonInfo1_Load(object sender, EventArgs e)
        {

        }

        private void uC_ShowPersonInfo1_SendRequestToGetImage(bool Request, string ImageKey)
        {

            Utilities.Methods.SetImage(uC_ShowPersonInfo1, Request, ImageKey);

        }

        private void _Refresh(clsPeople_BL NewInfo)
        {
            clsPeople_ = NewInfo;
            Utilities.Methods.Fill_UC_Controls(uC_ShowPersonInfo1, clsPeople_);

        }
        private void uC_ShowPersonInfo1_SendEditEvent()
        {
            Frm_Add_Edit_People AddEditPerson = new Frm_Add_Edit_People(clsPeople_.PersonID);

            AddEditPerson.Retrieve_1 = _Refresh;

            AddEditPerson.ShowDialog();
        }
    }
}
