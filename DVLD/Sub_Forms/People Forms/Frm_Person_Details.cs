using DVLD.User_Controls;
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
    public partial class Frm_Person_Details : Form
    {
        private int _ID = -1;
        private void InitializeDataMembers(int ID) 
        {
            _ID = ID;
        }
        public Frm_Person_Details(int ID = -1) : this()
        {
            InitializeDataMembers(ID);
        }
        public Frm_Person_Details()
        {
            InitializeComponent();
    
        }
      


        private void Frm_Person_Details_Load(object sender, EventArgs e)
        {
            PersonInfo_Form.InitializeDataMembers(_ID);
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
