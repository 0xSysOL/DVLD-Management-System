using DVLD.Properties;
using DVLD.Sub_Forms;
using DVLD_BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User_Controls
{
    public partial class UserControl_Person_Information : UserControl
    {

        #region Delegate
        public delegate void ReturnID(int ID);
        ReturnID ID1;
        private int _ReturnID(int ID)
        {
            return 0;
        }

        #endregion End

        private int _ID = -1;


        public  void InitializeDataMembers(int ID) 
        {
            _ID = ID;
        }
        public UserControl_Person_Information()
        {
            InitializeComponent();
            
        }

      

        private void LoadData() 
        {
              if (_ID == -1)
                return;

            DataTable PersonInfo = clsPeople_BL.GetPersonByID(_ID);

            if (PersonInfo == null) return;

            Label_Variable_PersonID.Text =
                PersonInfo.Rows[0]["PersonID"].ToString();
            Label_Variable_PersonNationalNo.Text = 
                PersonInfo.Rows[0]["NationalNo"].ToString();
            Label_Variable_PersonName.Text =
                PersonInfo.Rows[0]["FirstName"].ToString() + " " +
                PersonInfo.Rows[0]["SecondName"].ToString() + " " +
                PersonInfo.Rows[0]["ThirdName"].ToString() + " " +
                PersonInfo.Rows[0]["LastName"].ToString();
 
            Label_Variable_PersonGendor.Text = PersonInfo.Rows[0]["Gendor"].ToString();
            Label_Variable_PersonDateOfBirth.Text =Convert.ToDateTime( PersonInfo.Rows[0]["DateOfBirth"]).ToString("yyyy-MM-dd");
            Label_Variable_PersonCountry.Text = PersonInfo.Rows[0]["Nationality"].ToString();
            Label_Variable_PersonEmail.Text = PersonInfo.Rows[0]["Email"].ToString();
            Label_Variable_PersonPhone.Text = PersonInfo.Rows[0]["Phone"].ToString();
            Label_Variable_PersonAddress.Text = PersonInfo.Rows[0]["Address"].ToString();
            // Label_Variable_PersonID.Text = PersonInfo.Rows[0]["_ImagePath"].ToString();
            string ImageKey = PersonInfo.Rows[0]["ImagePath"].ToString();
      Pic_PersonImage.ImageLocation = clsPeople_BL.FindImagePath(ImageKey);

 
            CheckPersonGendor();
        }

        private void PersonInformation_Load(object sender, EventArgs e)
        {
      

        }

        private void Person_Card_Enter(object sender, EventArgs e)
        {
            LoadData();
        }
        private void CheckPersonGendor()
        {
            Pic_PersonGendor.Image = (Label_Variable_PersonGendor.Text == "Male")
                ? Resources.male_gender : Resources.femenine;

        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
           
        }

        private void Pic_PersonImage_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel_EditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_AddEditPerson_ add_Edit_Person = new Frm_AddEditPerson_(Convert.ToInt32(Label_Variable_PersonID.Text));

            add_Edit_Person.ShowDialog();
         
            LoadData();
        }
    }
}
