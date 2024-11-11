using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Slect_Login_Form : Form
    {
        public Slect_Login_Form()
        {
            InitializeComponent();
        }

        private void hospital_btn_Click(object sender, EventArgs e)
        {
            Hospital_Login_Form hospital_login_form = new Hospital_Login_Form();
            hospital_login_form.ShowDialog();
            this.Hide();

        }

        private void patient_btn_Click(object sender, EventArgs e)
        {
            Patient_Login_Form petient_login_form = new Patient_Login_Form();
            petient_login_form.ShowDialog();
            this.Hide();

        }

        private void Slect_Login_Form_Load(object sender, EventArgs e)
        {
            DBconn isDBcontrue = new DBconn();
            isDBcontrue.OpenConnection();

            DBconn2 dbconn2 = new DBconn2();
            dbconn2.OpenConnection();

        }
    }
}
