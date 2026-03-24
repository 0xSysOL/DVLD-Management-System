using System;
using System.Windows.Forms;

namespace DVLD.User_Controls
{
    public partial class UC_Filter : UserControl
    {

        public UC_Filter()
        {
            InitializeComponent();
            FillComboBox("None");
            HideTextBox();
        }
        #region Events
        public event Action<string, object> EvFilter;
        protected virtual void SendResult(string FilterType, object Value)
        {
            Action<string, object> handler = EvFilter;
            if (handler != null)
                handler(FilterType, Value);


        }


        bool IsInt = false;
        public event Action<int> Ev_IsInt;
        protected virtual void IsColumnIntType(int Index)
        {

            Action<int> Handler = Ev_IsInt;

            if (Handler != null)
                Handler(Index);


        }
        public void Answer_IsInt(bool An)
        {
            IsInt = An;
        }


        public event Action<string> EvClickedSearchButton;
        protected virtual void Send(string Value) 
        {
            Action<string> handler = EvClickedSearchButton;

            if (handler != null)
                handler(Value);

        }

        #endregion End



        public void ShowPicButtonSearch() 
        {
        Pic_SearchForPerson.Visible = true;
        }
        public void ShowTextBox() 
        {
            TB_Search.Visible = true;
        }
        public void HideTextBox()
        {
            TB_Search.Visible = false;
        }
        public void ShowComboBox_YesNo()
        {
            ComboBox_YesNo.Visible = true;
            TB_Search.Visible = false;
        }
        public void HideComboBox_YesNo()
        {
            ComboBox_YesNo.Visible = false;

        }




        private void TB_Search_KeyPress(object sender, KeyPressEventArgs e)
        {


            //IsColumnIntType(ComboBOX.SelectedIndex);

            if (IsInt)
            {
                if (char.IsDigit(e.KeyChar))
                    e.Handled = false;
                else if (char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;

            }



        }
        private void ComboBOX_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ComboBOX.SelectedIndex != 0)
                ShowTextBox();
            else
            {
                TB_Search.Visible = false;
                ComboBox_YesNo.Visible = false;
            }

            IsColumnIntType(ComboBOX.SelectedIndex);


        }

        public void SelectComboBox() 
        {
            if (ComboBOX.Items.Count != 0)
            {
                ComboBOX.SelectedIndex = 0;
                TB_Search.Visible = false;
            }
        }
        public void FillComboBox(DataGridView _DataGridView)
        {
            ComboBOX.Items.Clear();
            ComboBOX.Items.Add("None");


            //if (DataType[0] == typeof(string))
            foreach (DataGridViewColumn column in _DataGridView.Columns)
            {


                ComboBOX.Items.Add(column.Name);


            }

            SelectComboBox();




        }
        public void FillComboBox(string Value) 
        {
            ComboBOX.Items.Add(Value);
            SelectComboBox();
            
        }


        private void ComboBox_YesNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_YesNo.SelectedItem.ToString() == "Yes")
                SendResult(ComboBOX.SelectedItem.ToString(), "1");

            else if ((ComboBox_YesNo.SelectedItem.ToString() == "No"))
                SendResult(ComboBOX.SelectedItem.ToString(), "0");
            else
                SendResult("","");

        }

        private void TB_Search_TextChanged(object sender, EventArgs e)
        {

            SendResult(ComboBOX.SelectedItem.ToString(), TB_Search.Text);

        }

        private void Pic_SearchForPerson_Click(object sender, EventArgs e)
        {

            Send(TB_Search.Text);

        }


        private void UC_Filter_Load(object sender, EventArgs e)
        {

        }




    }
}
