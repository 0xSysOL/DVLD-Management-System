using DVLD.User_Controls;
using DVLD_BusinessLogic;
using DVLD_BussinessLogic.Application_Classes.Application;
using DVLD_BussinessLogic.Drivers;
using DVLD_BussinessLogic.License_Classes;
using System;
using System.Windows.Forms;

namespace DVLD.Sub_Forms.License
{
    public partial class Frm_ShowPersonLicenseHistory : Form
    {
        int _PersonID;
        int _DriverID;
        public void InitializeUC(int ApplicationID)
        {
            clsPeople_BL Person = new clsPeople_BL(clsApplication_BL.GetPersonID(ApplicationID));
            Utilities.Methods.Fill_UC_Person_Controls(UC_ShowPersonInfo, Person);
            InitializeDataGridsV(Person.PersonID);

        }
        public void InitializeDataGridsV(int PersonID)
        {
            _PersonID = PersonID;
            _DriverID = clsDriver_BL.GetDriverIDByPersonID(PersonID);

            _DataGridView_Local.DataSource = clsLicense_BL.GetAllPersonLocalLicense(_DriverID);
            Label_Variable_Local_Records.Text = _DataGridView_Local.RowCount.ToString();

            _DataGridView_International.DataSource = clsLicense_BL.GetAllPersonInternationalLicense(_DriverID);
            Label_Variable_International_Records.Text = _DataGridView_International.RowCount.ToString();

        }
        public Frm_ShowPersonLicenseHistory(int ApplicationID)
        {
            InitializeComponent();
            InitializeUC(ApplicationID);



        }
        public Frm_ShowPersonLicenseHistory(int PersonID,string ContextPerson = "By Person")
        {
            InitializeComponent();
            clsPeople_BL Person = new clsPeople_BL(PersonID);
            Utilities.Methods.Fill_UC_Person_Controls(UC_ShowPersonInfo, Person);
            InitializeDataGridsV(Person.PersonID);
        }

        private void Frm_ShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {

        }

     
        private void UC_ShowPersonInfo_SendRequestToGetImage(bool Request, string ImageKey)
        {

            Utilities.Methods.SetImage(UC_ShowPersonInfo, Request, ImageKey);

        }


    }
}
