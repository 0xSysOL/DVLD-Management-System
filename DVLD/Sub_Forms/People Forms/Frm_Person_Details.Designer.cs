namespace DVLD.Sub_Forms
{
    partial class Frm_Person_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Form_Title = new System.Windows.Forms.Label();
            this.PersonInfo_Form = new DVLD.User_Controls.UserControl_Person_Information();
            this.SuspendLayout();
            // 
            // Btn_Close
            // 
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Close.Location = new System.Drawing.Point(675, 389);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(76, 29);
            this.Btn_Close.TabIndex = 31;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Form_Title
            // 
            this.Form_Title.AutoSize = true;
            this.Form_Title.BackColor = System.Drawing.Color.Transparent;
            this.Form_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form_Title.ForeColor = System.Drawing.Color.Red;
            this.Form_Title.Location = new System.Drawing.Point(281, 36);
            this.Form_Title.Name = "Form_Title";
            this.Form_Title.Size = new System.Drawing.Size(213, 33);
            this.Form_Title.TabIndex = 32;
            this.Form_Title.Text = "Person Details ";
            // 
            // PersonInfo_Form
            // 
            this.PersonInfo_Form.Location = new System.Drawing.Point(12, 91);
            this.PersonInfo_Form.Name = "PersonInfo_Form";
            this.PersonInfo_Form.Size = new System.Drawing.Size(751, 292);
            this.PersonInfo_Form.TabIndex = 0;
            // 
            // Frm_Person_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 430);
            this.Controls.Add(this.Form_Title);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.PersonInfo_Form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Person_Details";
            this.Text = "Frm_Person_Details";
            this.Load += new System.EventHandler(this.Frm_Person_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.UserControl_Person_Information PersonInfo_Form;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label Form_Title;
    }
}