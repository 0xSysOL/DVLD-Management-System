using DVLD_BusinessLogic;
using DVLD_BussinessLogic;
using System;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.People_Forms
{
    public partial class Frm_Add_Edit_People : Form
    {
        clsPeople_BL clsPeople = new clsPeople_BL();

        public Frm_Add_Edit_People()
        {
            InitializeComponent();
        }

        public delegate void RetrieveDate(clsPeople_BL clsPeople);
        public RetrieveDate Retrieve_1;

       
        private void Frm_Add_Edit_People_Load(object sender, EventArgs e)
        {
            UC_AddEditPerson.InitializeComboBOX_Countries(clsCountries_BL.GetCountries());
            
                
        }


        private void UC_AddEditPerson_NeedImage(bool Response)
        {

            if (Response)
            {

                string ImagePath = Utilities.Methods.OpenFileSystem();
                UC_AddEditPerson.SetImage(ImagePath);

            }

        }

        private void uC_AddEditPerson1_IsNationalNoExists(string NationalNo)
        {
            if (clsPeople_BL.IsNationalNoExists(NationalNo))
                UC_AddEditPerson.SetResponseForConfirmation_NationalNo(true);
            else
                UC_AddEditPerson.SetResponseForConfirmation_NationalNo(false);


        }
        private void UC_AddEditPerson_SaveData(bool Saved)
        {

            if (!Saved)
                return;


            clsPeople.FirstName = UC_AddEditPerson.GetFirstName();
            clsPeople.SecondName = UC_AddEditPerson.GetSecondName();
            clsPeople.ThirdName = UC_AddEditPerson.GetThirdName();
            clsPeople.LastName = UC_AddEditPerson.GetLastName();
            clsPeople.NationalNo = UC_AddEditPerson.GetNationalNo();
            clsPeople.DateOfBirth = UC_AddEditPerson.GetDateOfBirth();
            clsPeople.Gendor = UC_AddEditPerson.GetGendor();
            clsPeople.Address = UC_AddEditPerson.GetAddress();
            clsPeople.Phone = UC_AddEditPerson.GetPhone();
            clsPeople.Email = UC_AddEditPerson.GetEmail();
            clsPeople.CountryName = UC_AddEditPerson.GetCountryName();
            clsPeople.ImagePath = UC_AddEditPerson.GetImagePath();

            string Mode = clsPeople.GetModeType();
            if (clsPeople.Save())
            {
                Utilities.Methods.Ut_ShowMessageBox(Mode);
                Label_FormTitle.Text = "Update Person";
                Label_Variable_PersonID.Text = clsPeople.PersonID.ToString();

            }
            else
                MessageBox.Show("Something Wrong Please Try Again!!", "Error Field", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }


        private void UC_AddEditPerson_SendMessageToClose()
        {
            /* If ID = -1 that's means the user  saved wrong Information 
                 OR He Closed the SubForm that have UC_AddEditPerson */
            if (clsPeople.PersonID != -1)
                Retrieve_1?.Invoke(clsPeople);


            this.Close();

        }

        private void uC_AddEditPerson1_Load(object sender, EventArgs e)
        {

        }
    }
}
