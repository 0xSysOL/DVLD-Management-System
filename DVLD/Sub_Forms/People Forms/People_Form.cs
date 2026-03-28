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
        }


        private void ShowPerson_TSMI_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);
            Frm_Person_Details frm_Person = new Frm_Person_Details(ID);

            frm_Person.ShowDialog();


        }



        private void EditPerson_TSMI_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(_DataGridView.CurrentRow.Cells[0].Value);

            Frm_Add_Edit_People frm_Add = new Frm_Add_Edit_People(ID);

            frm_Add.ShowDialog();


            Fill_DataGridView();
        }

        private void DeletePerson_TSMI_Click(object sender, EventArgs e)
        {
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
    }






}
