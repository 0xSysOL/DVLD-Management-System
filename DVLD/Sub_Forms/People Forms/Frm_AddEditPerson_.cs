using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Sub_Forms
{
    public partial class Frm_AddEditPerson_ : Form 
    {

        

        private int _ID = -1;
        private void InitializeDataMember(object ID) 
        {

            _ID = (ID == null) ? -1 : (int)ID;
        }
        private void Initialize_eMode(int ID)
        {
            if (ID != -1)
            {
                Label_FormTitle.Text = "Update person";
                Label_Variable_ID.Text =  ID.ToString();

            }
         
        }
  
        public Frm_AddEditPerson_()
        {
            InitializeComponent();
            

        }
        public Frm_AddEditPerson_(int ID) : this()
        {

            Initialize_eMode(ID);
            InitializeDataMember(ID);


        }
         

        private void Add_Edit_Person1_Load(object sender, EventArgs e)
        {
            if(_ID != -1)
            add_Edit_Person_UC.InitializeDataMember(_ID);
        }

        private void Frm_AddEditPerson__Load(object sender, EventArgs e)
        {
            add_Edit_Person_UC.DataBack += DataBack;
            add_Edit_Person_UC.close += CloseForm;
        }

        private void DataBack(int ID) 
        {
            Label_FormTitle.Text = "Edit Person";
            Initialize_eMode(ID);

        }
        private void CloseForm() 
        {

            this.Close();

        }

    }
}
