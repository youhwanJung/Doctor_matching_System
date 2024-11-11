using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout_test
{
    public partial class Patient_Login_Form : Form
    {
        public Patient_Login_Form()
        {
            InitializeComponent();
        }

        private void join_membership_btn_Click(object sender, EventArgs e)
        {
            Patient_Join_Membership_Form patient_join_membership_form = new Patient_Join_Membership_Form();
            patient_join_membership_form.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Patient_Info_Save_Form patient_info_save_form = new Patient_Info_Save_Form();
            patient_info_save_form.Show();

            foreach (Form form in Application.OpenForms)
            {
                if (form is Login_Select_Form)
                {
                    form.Hide();
                    break; // 원하는 폼을 찾았으면 반복을 종료
                }
            }
            this.Close();
        }
    }
}
