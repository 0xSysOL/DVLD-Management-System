using DVLD.Properties;
using System;
using System.Windows.Forms;

namespace DVLD.User_Controls
{
    public partial class UC_ShowPersonInfo : UserControl
    {
        public UC_ShowPersonInfo()
        {
            InitializeComponent();
        }

        public event Action<int> SendPersonID;
        protected virtual void Send(int ID) 
        {
            Action<int> action = SendPersonID;
            if (action != null)
                action(ID);
        }

        public event Action<bool,string> SendRequestToGetImage;
        protected virtual void SendRequestImage(bool Request,string ImageKey)
        {

            Action<bool,string> action = SendRequestToGetImage;
            if (action != null)
                action(Request,ImageKey);

        }


        public event Action SendEditEvent;

        protected virtual void SendRequestEditPerson()
        {
            Action action = SendEditEvent;
            if (action != null)
                action();

        }


       public enum eModeIsFull { Yes,No};
       public  eModeIsFull eMode = eModeIsFull.No;


        

        public void ResetControls()
        {

            string Dot = "......";
            //PersonID = Dot;
            Label_Variable_PersonID.Text = Dot;
            Label_Variable_PersonName.Text = Dot;
            Label_Variable_PersonNationalNo.Text = Dot;
            Label_Variable_PersonGendor.Text = Dot;
            Label_Variable_PersonAddress.Text = Dot;
            Label_Variable_PersonDateOfBirth.Text = Dot;
            Label_Variable_PersonPhone.Text = Dot;
            Label_Variable_PersonCountry.Text = Dot;
            Label_Variable_PersonEmail.Text = Dot;
            _SetImage(null);
            Send(-1);
            eMode = eModeIsFull.No;

        }

        public void SetImage(string ImagePath)
        {

            Pic_PersonImage.ImageLocation = ImagePath;

        }

        private void _SetImage(string ImageKey)
        {

            if(!string.IsNullOrEmpty(ImageKey))
            {
                SendRequestImage(true,ImageKey);
                return;
            }

            string Gendor = Label_Variable_PersonGendor.Text;
            if (Gendor == "Male")
                Pic_PersonImage.Image = Resources.man_Show;
            else if (Gendor == "Female")
                Pic_PersonImage.Image = Resources.woman_Show;
            else
                Pic_PersonImage.Image = Resources.unknown;

        }
        public void FillControls(string PersonID,string FullName, string NationalNo, string Gendor,
           string Address, string DateOfBirth, string Phone, string Country, string Email = null,string ImageKey = null)
        {

            Label_Variable_PersonID.Text = PersonID;
            Label_Variable_PersonName.Text = FullName;
            Label_Variable_PersonNationalNo.Text = NationalNo;
            Label_Variable_PersonGendor.Text = Gendor;
            Label_Variable_PersonAddress.Text = Address;
            Label_Variable_PersonDateOfBirth.Text = DateOfBirth;
            Label_Variable_PersonPhone.Text = Phone;
            Label_Variable_PersonCountry.Text = Country;
            Label_Variable_PersonEmail.Text = (!string.IsNullOrEmpty(Email)) ? Email : ".......";
            
            Send(Convert.ToInt32(PersonID));

            _SetImage(ImageKey);

        }
        private void UC_ShowPersonInfo_Load(object sender, EventArgs e)
        {

        }

        private void Person_Card_Enter(object sender, EventArgs e)
        {

        }

        private void LinkLabel_EditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendEditEvent();
        }
    }
}
