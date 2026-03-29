using DVLD.Sub_Forms.People_Forms;
using DVLD_BusinessLogic;
using System;
using System.Windows.Forms;

namespace DVLD.Sub_Forms
{
    public partial class Frm_People : Form
    {
        public Frm_People()
        {
            InitializeComponent();

        }

        private void Fill_DataGridView(string FilterType = "", object Filter = null)
        {
            _DataGridView.DataSource = clsPeople_BL.GetAllPeople(FilterType, Filter);
            Label_Variable_Records.Text = _DataGridView.RowCount.ToString();

        }
        private void People_Form_Load(object sender, EventArgs e)
        {
            Fill_DataGridView();
            UC_Filter.FillComboBox(_DataGridView);
        }

        public bool IsDataGridViewEmpty()
        {

            return _DataGridView.CurrentRow == null;
        }
        private void ShowPerson_TSMI_Click(object sender, EventArgs e)
        {
            if (IsDataGridViewEmpty())
                return;
           


            int ID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);
            Frm_Person_Details frm_Person = new Frm_Person_Details(ID);

            frm_Person.ShowDialog();


        }



        private void EditPerson_TSMI_Click(object sender, EventArgs e)
        {
            if (IsDataGridViewEmpty())
                return;


            int ID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);

            Frm_Add_Edit_People frm_Add = new Frm_Add_Edit_People(ID);

            frm_Add.ShowDialog();


            Fill_DataGridView();
        }

        private void DeletePerson_TSMI_Click(object sender, EventArgs e)
        {
            if (IsDataGridViewEmpty())
                return;


            int ID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);

            if (clsPeople_BL.DeletePerson(ID))
                MessageBox.Show("Person Deleted Successfully", "Info");
            else
                MessageBox.Show("Can't Delete Person Because Has Date Link to it", "Info"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);



            Fill_DataGridView();
        }

        private void LoadAddEditForm()
        {

            Frm_Add_Edit_People frm_Add = new Frm_Add_Edit_People();

            frm_Add.ShowDialog();


            Fill_DataGridView();
        }
        private void AddNewPerson_TSMI_Click(object sender, EventArgs e)
        {
       
            LoadAddEditForm();
        }
        private void PicButton_AddNewPerson_Click(object sender, EventArgs e)
        {
            LoadAddEditForm();
        }
        enum eIndex { PersonID=1,NationalNo,
            FirstName,
            SecondName,
            ThirdName,
            LastName,
            Gendor,
            DateOfBirth,
            CountryName,
            PhoneNumber,
            Email



        }
        private void uC_Filter1_Ev_IsInt(int Index)
        {

            switch ((eIndex)Index)
            {
                case eIndex.PersonID:
                    UC_Filter.Answer_IsInt(true);
                    break;
                case eIndex.DateOfBirth:
                    // will be Change
                    UC_Filter.Answer_IsInt(false); break;
                case eIndex.Gendor:
                    UC_Filter.ShowComboBox_YesNo();
                    break;




                case eIndex.NationalNo:
                case eIndex.FirstName:
                case eIndex.SecondName:
                case eIndex.ThirdName:
                case eIndex.LastName:
                case eIndex.CountryName:
                case eIndex.PhoneNumber:
                case eIndex.Email:
                    UC_Filter.Answer_IsInt(false);
                    break;

            }


        }

        private void uC_Filter1_EvFilter(string FilterType, object Value)
        {
            Fill_DataGridView(FilterType,Value);

        }

        private void SendEmail_TSMI_Click(object sender, EventArgs e)
        {
            if (IsDataGridViewEmpty())
                return;


        }

        private void PhoneCall_TSMI_Click(object sender, EventArgs e)
        {
            if (IsDataGridViewEmpty())
                return;


        }
   
    
    
    }






}
