using DVLD.Sub_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        // Load People Form
        private void MS__People_Click(object sender, EventArgs e)
        {

            Frm_People people_Form = new Frm_People();

            people_Form.ShowDialog();


        }


        // Load User Form
        private void MS__Users_Click(object sender, EventArgs e)
        {
            Frm_ManageUsers Users_Form = new Frm_ManageUsers();

            Users_Form.ShowDialog();
        }
    }
}
