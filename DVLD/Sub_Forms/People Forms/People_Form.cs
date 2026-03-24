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
    public partial class Frm_People : Form
    {
        public Frm_People()
        {
            InitializeComponent();

        }

        private void People_Form_Load(object sender, EventArgs e)
        {

        }

       

        private void getDataWithFilter_UC1_Load(object sender, EventArgs e)
        {
            getDataWithFilter_UC1.LoadSetting("People");
           
        }
    }
}
