using DVLD.Sub_Forms.Users_Forms;
using DVLD.User_Controls;
using DVLD_BusinessLogic;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DVLD.Utilities
{
    internal class Methods
    {

        public static bool IsDataTableEmpty(DataTable Data)
        {
            if (Data.Rows.Count == 0)
            {

                return true;
            }
            return false;
        }


        public static bool sPersonInfoEmpty(string firstName, string secondName, string thirdName, string lastName, string nationalNo, string phone,
string address)
        {

            return (string.IsNullOrWhiteSpace(firstName) ||
                    string.IsNullOrWhiteSpace(secondName) ||
                    string.IsNullOrWhiteSpace(thirdName) ||
                    string.IsNullOrWhiteSpace(lastName) ||
                    string.IsNullOrWhiteSpace(address) ||
                    string.IsNullOrWhiteSpace(nationalNo) ||
                    string.IsNullOrWhiteSpace(phone));


        }
        public static bool IsDateInCurrentRange(DateTime Max, DateTimePicker Value)
        {

            if (Value == null)
                return false;


            return (Value.Value <= Max);
        }

        public static bool Fill_UC_Controls(UC_ShowPersonInfo UC_Fill, clsPeople_BL PersonData)
        {
            // If Object Null We will stop Processing
            if (PersonData == null)
                return false;


            // Collecting the Names
            string FullName = PersonData.FirstName + " " + PersonData.SecondName + " " + PersonData.ThirdName + " " + PersonData.LastName;

            // Fill Controls And Will be Showing On Display.
            UC_Fill.FillControls(
                PersonData.PersonID.ToString(), FullName, PersonData.NationalNo,
                (PersonData.Gendor == 0) ? "Male" : "Female", PersonData.Address,
                PersonData.DateOfBirth.ToShortDateString(),
                PersonData.Phone, PersonData.CountryName, PersonData.Email, PersonData.ImageKey);


            return true;
        }
        public static bool Fill_UC_Controls(UC_ShowPersonInfo UC_Fill, DataTable PersonData)
        {


            if (IsDataTableEmpty(PersonData))
            {
                UC_Fill.ResetControls();
                return false;
            }
            string PersonID = PersonData.Rows[0]["PersonID"].ToString();
            string FullName =
                 PersonData.Rows[0]["FirstName"].ToString() + " " +
                PersonData.Rows[0]["SecondName"].ToString() + " " +
                PersonData.Rows[0]["ThirdName"].ToString() + " " +
                PersonData.Rows[0]["LastName"].ToString();

            string Email = PersonData.Rows[0]["Email"].ToString() != null ?
                PersonData.Rows[0]["Email"].ToString() : null;
            DateTime DateOfBirth = Convert.ToDateTime(PersonData.Rows[0]["DateOfBirth"].ToString());

            UC_Fill.FillControls(PersonID,
            FullName,
            PersonData.Rows[0]["NationalNo"].ToString(),
             PersonData.Rows[0]["Gendor"].ToString(),
              PersonData.Rows[0]["Address"].ToString(),
               DateOfBirth.ToShortDateString(),
                PersonData.Rows[0]["Phone"].ToString(),
                 PersonData.Rows[0]["Nationality"].ToString(),
                  Email,
                  PersonData.Rows[0]["ImagePath"].ToString()
                );


            return true;
        }


        public static void FillComboBOX(DataTable dataTable, ComboBox ComboBOX)
        {

            if (dataTable == null) return;

            foreach (DataRow data in dataTable.Rows)
            {
                ComboBOX.Items.Add(data[0]);
            }
            if (ComboBOX != null)
                ComboBOX.SelectedIndex = 0;


        }


        public static string OpenFileSystem()
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFile.DefaultExt = "png";

            if (openFile.ShowDialog() == DialogResult.OK)
                return openFile.FileName;



            return null;

        }
        public static void Ut_ShowMessageBox(string Mode)
        {

            MessageBox.Show("User " + ((Mode == "Update") ? "Updated" : "Added") + " Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        public static void Show_AddEdit_NewUser(int ID = -1)
        {

            Frm_AddNewUser frm_AddNew = new Frm_AddNewUser(ID);
            frm_AddNew.ShowDialog();


        }


        public static void SetImage(UC_ShowPersonInfo User_Control, bool Request, string ImageKey)
        {

            if (Request != false)
                User_Control.SetImage(clsPeople_BL.FindImagePath(ImageKey));


        }


        public static bool IsDecimal(TextBox TB)
        {

            if (TB.Text.All(c => char.IsDigit(c) || c == '.'))
                return true;
            else
                return false;



        }

    }
}
