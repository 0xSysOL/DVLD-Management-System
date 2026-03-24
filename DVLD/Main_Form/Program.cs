using DVLD.Sub_Forms.Users_Forms;
using DVLD_BussinessLogic.Users_Classes.User_Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    internal static class Program
    {
      
        private static bool LoadLoginForm() 
        {

            Frm_LoginScreen frm_Login = new Frm_LoginScreen();

            frm_Login.ShowDialog();

            if (CurrentUser.GetUserID() != -1)
                return true;
            else
                return false;

        }
         /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if(LoadLoginForm())
            Application.Run(new Main_Form());


        }
    }
}
