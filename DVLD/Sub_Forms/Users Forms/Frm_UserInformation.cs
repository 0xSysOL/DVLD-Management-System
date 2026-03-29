using DVLD.Sub_Forms.People_Forms;
using DVLD.User_Controls;
using DVLD_BusinessLogic;
using DVLD_BussinessLogic.Users_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.Users_Forms
{
    public partial class Frm_UserInformation : Form
    {
        clsUsers_BL clsUser;
        clsPeople_BL clsPerson;
        private void InitializePerson_S_User() 
        {
            clsPerson = new clsPeople_BL(clsUser.PersonID);

            Utilities.Methods.Fill_UC_Controls(UC_ShowPersonInfo_1,clsPerson);
        }
        private void InitializeUser(int ID)
        {
            if (ID <= 0)
                return;

            clsUser = new clsUsers_BL(ID);
            UC_LoginInfo_2.SetUserID(clsUser.UserID);
            UC_LoginInfo_2.SetUsername(clsUser.Username);
            UC_LoginInfo_2.SetIsActive(clsUser.IsActive);


        }
        public Frm_UserInformation(int ID)
        {
            InitializeComponent();
            InitializeUser(ID);
            InitializePerson_S_User();
        }

        private void Frm_UserInformation_Load(object sender, EventArgs e)
        {

        }

        private void UC_ShowPersonInfo_1_Load(object sender, EventArgs e)
        {

        }

        private void UC_LoginInfo_2_Load(object sender, EventArgs e)
        {

        }

        private void UC_ShowPersonInfo_1_SendRequestToGetImage(bool Request, string ImageKey)
        {

                Utilities.Methods.SetImage(UC_ShowPersonInfo_1, Request, ImageKey);

        }


        private void SavePerson(clsPeople_BL PersonInfo)
        {
            clsPerson = PersonInfo;
            clsPerson.Save();
            Utilities.Methods.Fill_UC_Controls(UC_ShowPersonInfo_1, clsPerson);

        }
        private void UC_ShowPersonInfo_1_SendEditEvent()
        {
            Frm_Add_Edit_People frm_Add_Edit = new Frm_Add_Edit_People(clsUser.PersonID);
            frm_Add_Edit.Retrieve_1 = SavePerson;
            frm_Add_Edit.ShowDialog();


        }
    }
}
