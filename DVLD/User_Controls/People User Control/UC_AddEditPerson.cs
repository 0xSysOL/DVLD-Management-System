using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.User_Controls.People_User_Control
{
    public partial class UC_AddEditPerson : UserControl
    {

        private bool _IsNationalNoExists = false;
        enum eMode { Add, Update };
        eMode mode;


        #region Person Data

        public string GetFirstName()
        {
            return TB_FirstName.Text;
        }

        public string GetSecondName()
        {
            return TB_SecondName.Text;
        }

        public string GetThirdName()
        {
            return TB_ThirdName.Text;
        }

        public string GetLastName()
        {
            return TB_LastName.Text;
        }

        public string GetNationalNo()
        {
            return TB_NationalNo.Text;
        }

        public DateTime GetDateOfBirth()
        {
            return DatePiker_DateOfBirth.Value;
        }

        public byte GetGendor()
        {
            return Convert.ToByte((Radio_Male.Checked) ? 0 : 1);
        }

        public string GetPhone()
        {
            return TB_Phone.Text;
        }

        public string GetEmail()
        {
            return TB_Email.Text;
        }

        public string GetCountryName()
        {
            return ComboBOX_Countries.SelectedItem.ToString();
        }

        public string GetAddress()
        {
            return TB_Address.Text;
        }

        public string GetImagePath()
        {
            return Pic_PersonImage.ImageLocation;
        }

        #endregion
        public void InitializeComboBOX_Countries(DataTable dataTable)
        {

            Utilities.Methods.FillComboBOX(dataTable, ComboBOX_Countries);

        }
        public void InitializeData()
        {


        }
        private void _InitializeDateBox()
        {
            DatePiker_DateOfBirth.Value = DateTime.Now.AddYears(-18);
            DatePiker_DateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
            DatePiker_DateOfBirth.MinDate = DateTime.Today.AddYears(-115);


        }

        public UC_AddEditPerson()
        {
            InitializeComponent();
            _InitializeDateBox();
            InitializeData();
        }


        #region Events
        public event Action<bool> NeedImage;
        protected virtual void GetImage(bool Response)
        {
            Action<bool> Handler = NeedImage;
            if (Handler != null)
                Handler(Response);


        }


        public event Action<string> IsNationalNoExists;
        protected virtual void SendNationalNo(string NationalNo)
        {
            Action<string> Handler = IsNationalNoExists;
            if (Handler != null)
                Handler(NationalNo);


        }


        public event Action<bool> SaveDate;
        protected virtual void Fun_DataSave(bool Saved)
        {

            Action<bool> Handler = SaveDate;
            if (Handler != null)
                Handler(Saved);

        }


        public event Action SendMessageToClose;
        protected virtual void _SendMessageToClose(bool Message)
        {

            Action Handler = SendMessageToClose;
            if (Handler != null)
                Handler();

        }

        #endregion End


        public void SetImage(string ImagePath)
        {

            Pic_PersonImage.ImageLocation = ImagePath;

        }

        public void SetResponseForConfirmation_NationalNo(bool Message_YesNo)
        {
            _IsNationalNoExists = Message_YesNo;

        }
        private void UC_AddEditPerson_Load(object sender, EventArgs e)
        {

        }


        private bool IsDataEmpty()
        {
            if (Utilities.Methods.sPersonInfoEmpty(
         TB_FirstName.Text,
         TB_SecondName.Text,
         TB_ThirdName.Text,
         TB_LastName.Text,
         TB_NationalNo.Text,
         TB_Phone.Text,
         TB_Address.Text
   ))
            {
                MessageBox.Show("Please fill all Required Field!", "Error Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;

            }

            return false;
        }
        private bool IsDateInCurrentRange()
        {


            DateTime LessYear = DateTime.Now.AddYears(-18);
            if (!Utilities.Methods.IsDateInCurrentRange(LessYear, DatePiker_DateOfBirth))
            {
                MessageBox.Show("Date Of Birth Is Not valid", "Error Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private bool __IsNationalNoExists()
        {
            if (mode == eMode.Update)
                return false;

            SendNationalNo(TB_NationalNo.Text);
            if (_IsNationalNoExists)
            {
                MessageBox.Show("NationalNo Exists!!", "Error Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {


            if (IsDataEmpty() || !IsDateInCurrentRange() || __IsNationalNoExists())
                return;




            TB_NationalNo.Enabled = false;
            mode = eMode.Update;
            Fun_DataSave(true);

        }



        private void LinkLabel_SetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetImage(true);

        }

        private void LinkLabel_RemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            _SendMessageToClose(true);

        }

        private void GroubBox_Enter(object sender, EventArgs e)
        {

        }   

        private void Label_UserControlTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
