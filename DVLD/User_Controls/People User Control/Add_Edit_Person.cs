using DVLD.Properties;
using DVLD_BusinessLogic;
using DVLD_BussinessLogic;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

using System.ComponentModel.DataAnnotations;
namespace DVLD.User_Controls
{
    public partial class UserControl__Add_Edit_Person : UserControl
    {

        #region Delegae Service

        public delegate void ReturnID(int ID);
        public delegate void CloseCurrentForm();
        public ReturnID DataBack;
        public CloseCurrentForm close;
        private void ReturnIDtoCurrentForm(int ID)
        {
            DataBack?.Invoke(ID);
        }
        private void TellCurrentFormToTurnOff_Himself()
        {
            close?.Invoke();

        }
       
        #endregion End

        #region Data Members
        //enum eMode {Update=0,Add=1}
        //eMode _Mode = eMode.Add;
        string NationalNo_Equal = "";
        private int _ID = -1;
        clsPeople_BL clsPeople = new clsPeople_BL();
        #endregion End
        #region Initializtion Methods
        public void InitializeDataMember(int ID)
        {
            if (ID == -1) return;

            clsPeople = new clsPeople_BL(ID);
            _FillControls();
            _TurnOff_TB_NationalNo();

        }
        private void _InitializeDateBox()
        {
            DatePiker_DateOfBirth.Value = DateTime.Now.AddYears(-18);
            DatePiker_DateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
            DatePiker_DateOfBirth.MinDate = DateTime.Today.AddYears(-115);


        }

        private void _InitializeComboBOX_Countries()
        {
            DataTable dataTable = clsCountries_BL.GetCountries();
            if (dataTable == null) return;

            foreach (DataRow data in dataTable.Rows)
            {
                ComboBOX_Countries.Items.Add(data[0]);
            }


            ComboBOX_Countries.SelectedIndex = ComboBOX_Countries.FindString("Iraq");

        }

       
        #endregion end
        #region Contructors
        public UserControl__Add_Edit_Person()
        {

            InitializeComponent();
            _InitializeDateBox();
            _InitializeComboBOX_Countries();


        }



        #endregion End

        #region Validation

        private void _TurnOff_TB_NationalNo() 
        {
            TB_NationalNo.Enabled = false;
            ErrorProvider_UnEnabled.SetError(TB_NationalNo, "Con't Change it");

        }
        private void _TB_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
                ErroreProvider.SetError(textBox, "Field is required");


        }
        private void _TB_NationalNo_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
                ErroreProvider.SetError(textBox, "Field is required");

            if (NationalNo_Equal == textBox.Text) return;

            if (clsPeople_BL.IsNationalNoExists(textBox.Text))
            {
                ErroreProvider.SetError(textBox, "National No is use please choose another one");
                NationalNo_Equal = textBox.Text;
            }
            else
            {
                ErroreProvider.SetError(((TextBox)sender), "");
                NationalNo_Equal = "";
            }
        }
        private void _TB_Validated(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!string.IsNullOrWhiteSpace(textBox.Text))
                ErroreProvider.SetError(textBox, "");

        }
        private void _TB_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                ErroreProvider.SetError((TextBox)sender, "");
            }
            else
            {
                e.Handled = true;
                ErroreProvider.SetError((TextBox)sender, "Please Enter Numbers Only");
            }


        }
        private void _Validate_Picture_Unknown_MF(object sender, EventArgs e)
        {
            if (Pic_PersonImage.ImageLocation != null)
            {
                LinkLabel_SetImage.Visible = true;
                return;
            }
            

            Pic_PersonImage.Image = (Radio_Male.Checked) ? Resources.man_Show : Resources.woman_Show;


        }

        private void _TB_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;

        }
        private short _GetGendorFromRadio()
        {
            return Radio_Male.Checked == true ? (short)0 : (short)1;
        }
        private void _CheckGendor(short Gendor)
        {
            if (Gendor == 0)
                Radio_Male.Checked = true;
            else
                Radio_Female.Checked = true;


        }
        private void _IsEmailValid(object sender, CancelEventArgs e)
        {
            bool IsEmailValid = false;

                IsEmailValid = new EmailAddressAttribute().IsValid(TB_Email.Text);
            
         
                if (TB_Email.Text.Length == 0 || IsEmailValid) 
                    ErroreProvider.SetError(TB_Email, "");
                else
                    ErroreProvider.SetError(TB_Email, "Email Not valid");
            


        }
        
        
        #endregion End;

        private void _SelectCountryInComboBox(string CountryName)
        {

            ComboBOX_Countries.SelectedIndex = ComboBOX_Countries.FindString("Iraq");

        }
        private void _Add_Edit_Person_Load(object sender, EventArgs e)
        {

        }

        private void _FillControls()
        {

            TB_FirstName.Text = clsPeople.FirstName;
            TB_SecondName.Text = clsPeople.SecondName;
            TB_ThirdName.Text = clsPeople.ThirdName;
            TB_LastName.Text = clsPeople.LastName;
            TB_NationalNo.Text = clsPeople.NationalNo;
            TB_NationalNo.Enabled = false;

            DatePiker_DateOfBirth.Value = clsPeople.DateOfBirth;
            _CheckGendor(clsPeople.Gendor);
            TB_Address.Text = clsPeople.Address;
            TB_Phone.Text = clsPeople.Phone;
            TB_Email.Text = clsPeople.Email;
            Pic_PersonImage.ImageLocation = clsPeople.ImagePath;
            _SelectCountryInComboBox(clsPeople.CountryName);

        }
        private void _Btn_Save_Click(object sender, EventArgs e)
        {

            if (ComboBOX_Countries.SelectedItem == null)
            {
                ErroreProvider.SetError(ComboBOX_Countries, "Please Choose Country");
                return;
            }




            clsPeople.FirstName = TB_FirstName.Text;
            clsPeople.SecondName = TB_SecondName.Text;
            clsPeople.ThirdName = TB_ThirdName.Text;
            clsPeople.LastName = TB_LastName.Text;
            clsPeople.NationalNo = TB_NationalNo.Text;
            clsPeople.DateOfBirth = DatePiker_DateOfBirth.Value;
            clsPeople.Gendor = _GetGendorFromRadio();
            clsPeople.Address = TB_Address.Text;
            clsPeople.Phone = TB_Phone.Text;
            clsPeople.Email = TB_Email.Text;

            clsPeople.ImagePath = Pic_PersonImage.ImageLocation;
            clsPeople.CountryName = ComboBOX_Countries.SelectedItem.ToString();
            if (clsPeople.Save())
            {
                MessageBox.Show("Person Added SuccessFully");
                ReturnIDtoCurrentForm(clsPeople.PersonID);
                _TurnOff_TB_NationalNo();

            }
            else
                MessageBox.Show("Something Wrong Please Check from Your Data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        private void _LinkLabel_SetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFile.DefaultExt = "png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Pic_PersonImage.ImageLocation = openFile.FileName;
                LinkLabel_RemoveImage.Visible = true;
                clsPeople.ImagePath = openFile.FileName;
            }

        }

        private void _LinkLabel_RemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pic_PersonImage.ImageLocation = null;
            Pic_PersonImage.Image = null;
            Pic_PersonImage.Image = (Radio_Male.Checked) ? Resources.man_Show : Resources.woman_Show;
            LinkLabel_RemoveImage.Visible = false;
        }

        private void _Btn_Close_Click(object sender, EventArgs e)
        {
            TellCurrentFormToTurnOff_Himself();
        }

        private void _Pic_PersonImage_Click(object sender, EventArgs e)
        {

        }

        private void ComboBOX_Countries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroubBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
